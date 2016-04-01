using System;

namespace EventsSocialNet
{
    class User
    {      
        protected string name, secondName;
        DateTime bDate;

        event Action<User, string> PublicationAlertEvent;

        public User(string Name, string SecondName, DateTime bDate)
        {
            this.name = Name;
            this.secondName = SecondName;
            this.bDate = bDate;
        }
        public string FullName
        {
            get { return this.name + " " + this.secondName; }
        }
        public void MakePublication(string str)
        {            
            Console.WriteLine(str);
        }
        public void PublicationAlert(User person, string str)
        {
            Console.WriteLine("Уважаемый пользователь {0}, пользователь {1} написал:\n\"{2}\"", this.FullName,person.FullName,str);
        }
        public void Subscribe(User person)
        {
            this.PublicationAlertEvent += person.PublicationAlert;
        }
    }    


}