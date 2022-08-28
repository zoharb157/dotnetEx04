namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Title;

        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }

        private int m_ItemNumber;

        public int ItemNumber
        {
            get
            {
                return m_ItemNumber;
            }
            set
            {
                m_ItemNumber = value;
            }
        }

        internal abstract void OnChoose();
    }
}
