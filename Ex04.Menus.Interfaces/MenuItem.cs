namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
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
        internal abstract void OnChoose();
    }
}
