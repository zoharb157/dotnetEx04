namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        public delegate void ChooseEventHandler();
        public event ChooseEventHandler Chose;
         
        public ActionItem()
        {
            Chose = null;
        }

        public ActionItem(string i_Title, ChooseEventHandler i_Action)
        {
            Chose += i_Action;
            Title = i_Title;
        }

        internal override void OnChoose()
        {
            if (Chose != null)
            {
                Chose.Invoke();
            }
        }
    }
}
