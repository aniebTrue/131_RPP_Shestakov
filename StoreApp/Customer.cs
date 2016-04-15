namespace StoreApp
{
    interface ICustomer
    {
        string Name { get; set; }
        bool isOpt;
        bool isUsual;
        
    }
    class Customer:ICustomer
    {

    }
}
