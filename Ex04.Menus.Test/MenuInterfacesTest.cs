using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuInterfacesTest
    {
        public static void ShowMenu()
        {
            MainMenu mainMenu = new MainMenu();

            SubMenu subMenu1 = new SubMenu("Version and Spaces", false);
            subMenu1.AddItem(new ActionItem("Count Spaces", new Actions.CountSpaces()));
            subMenu1.AddItem(new ActionItem("Show Version", new Actions.ShowVersion()));
            mainMenu.AddItem(subMenu1);

            SubMenu subMenu2 = new SubMenu("Show Data/Time", false);
            subMenu2.AddItem(new ActionItem("Show Date", new Actions.ShowDate()));
            subMenu2.AddItem(new ActionItem("Show Time", new Actions.ShowTime()));
            mainMenu.AddItem(subMenu2);

            mainMenu.Show();
        }
    }
}
