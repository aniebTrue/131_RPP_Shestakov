namespace StoreApp
{
    interface IItem
    {
        int ItemID { get; set; }
        string ItemName { get; set; }
        void SellItem(int itemCount);
        void AddItemOnStore(int itemCount);

    }
    class Item : IItem
    {
        public Item(string name, int ID)
        {
            this.ItemID = ID;
            this.ItemName = name;
            this.CurentItemCount = 0;
        }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int CurentItemCount { get; private set; }
        public void SellItem(int itemCount)
        {
            if (this.CurentItemCount - itemCount >= 0) this.CurentItemCount -= itemCount;
        }
        public void AddItemOnStore(int itemCount)
        {
            if (itemCount >= 0) this.CurentItemCount += itemCount;
        }
    }
}
