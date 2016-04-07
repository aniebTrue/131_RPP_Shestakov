using System;

namespace EventsSocialNet
{
    class Program
    {
        static void Main(string[] args)
        {                    
            User user1 = new User("Иван","Смирнов",new DateTime(2001,1,1));
            User user2 = new User("Ольга", "Смирнова", new DateTime(2002, 1, 1));
            user1.MakePublication(user1.FullName);
        }
    }
}
