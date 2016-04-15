namespace StoreApp
{
    interface IItem
    {
        string ItemName { get; set; }
        double ItemCost { get; set; }
        void SellItem(int itemCount);
        void AddItemOnStore(int itemCount);

    }
    class Item : IItem
    {
        public Item(string name, double itemCost)
        {
            this.ItemName = name;
            this.CurentItemCount = 0;
            this.ItemCost = itemCost;
        }

        public double ItemCost { get; set; }
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
