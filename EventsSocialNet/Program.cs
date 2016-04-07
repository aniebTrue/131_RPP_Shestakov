using System;

namespace EventsSocialNet
{
    class Program
    {
        static void Main(string[] args)
        {                    
            User user1 = new User(1,"Иван","Смирнов");
            User user2 = new User(2, "Дмитрий", "Дрозд");

            userEvent evn = new userEvent();

            evn.Alert += user1.RecordAlert;

            evn.OnUserActions(user2);

            Console.ReadLine();

        }
    }
}
