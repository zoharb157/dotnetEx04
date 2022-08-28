namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly ActionInterface r_Action;

        public ActionItem(string i_Title, ActionInterface i_Action)
        {
            Title = i_Title;
            r_Action = i_Action;
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
