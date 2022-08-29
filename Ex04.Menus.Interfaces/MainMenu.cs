namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenu;

        public MainMenu()
        {
            r_MainMenu = new SubMenu("Main Interfaces", true);

            MenuItem exitItem = new ActionItem("Exit", null);
            exitItem.ItemNumber = 0;

            r_MainMenu.MenuItems.Add(exitItem);
        }
        public void Show()
        {
            r_MainMenu.OnChoose();
        }
        public void AddItem(MenuItem i_MenuItem)
        {
            r_MainMenu.AddItem(i_MenuItem);
        }
    }
}
