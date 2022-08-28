using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;
        private readonly bool r_IsMainMenu;

        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public SubMenu(string i_Title, bool i_IsMainMenu)
        {
            Title = i_Title;
            r_MenuItems = new List<MenuItem>();
            r_IsMainMenu = i_IsMainMenu;
        }

        private void AddBackItemIfNeeded()
        {
            if (r_MenuItems.Count == 0)
            {
                MenuItem backItem = new ActionItem("Back", null);
                backItem.ItemNumber = 0;
                r_MenuItems.Add(backItem);
            }
        }

        public void AddItem(MenuItem i_Item)
        {
            AddBackItemIfNeeded();
            i_Item.ItemNumber = r_MenuItems.Count;
            r_MenuItems.Add(i_Item);
        }

        private int getValidUserInput()
        {
            string userInput = string.Empty;
            int userInputNumber = 0;
            bool isNumber = false;
            bool isInRange = false;

            while (!isNumber || !isInRange)
            {
                userInput = Console.ReadLine();

                isNumber = int.TryParse(userInput, out userInputNumber);
                isInRange = (userInputNumber >= 0) && (userInputNumber <= r_MenuItems.Count);
                if (!isNumber)
                {
                    Console.Write("Please enter a valid number");
                }
                else if (!isInRange)
                {
                    Console.Write("Number is not in range");
                }
            }

            return userInputNumber;
        }

        private void showSubMenu()
        {
            int userInputNumber = -1;

            while (userInputNumber != 0)
            {
                if (!r_IsMainMenu)
                {
                    Console.Write("Sub Menu - ");
                }

                Console.WriteLine(Title);

                foreach (MenuItem menuItem in r_MenuItems)
                {
                    Console.WriteLine(string.Format("{0}. {1}", menuItem.ItemNumber, menuItem.Title));
                }

                userInputNumber = getValidUserInput();

                Console.Clear();

                if (userInputNumber != 0)
                {
                    r_MenuItems[userInputNumber].OnChoose();
                }
            }
        }

        internal override void OnChoose()
        {
            if (r_MenuItems.Count != 0)
            {
                showSubMenu();
            }
        }
    }
}
