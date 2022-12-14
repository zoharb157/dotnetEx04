namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly ActionInterface r_Action;

        public ActionItem(string i_Title, ActionInterface i_Action)
        {
            r_Action = i_Action;
            Title = i_Title;
        }

        internal override void OnChoose()
        {
            if (r_Action != null)
            {
                r_Action.Invoke();
            }
        }
    }
}
