using System;

namespace EventsSocialNet
{
    delegate void UserAction(User person);

    class userEvent
    {
        public event UserAction Alert;

        public void OnUserActions(User user)
        {
            Alert(user);
        }
    }

    class User
    {      
        int ID;
        protected string name, secondName;
        //private DateTime bDate;

        public User(int ID, string Name, string SecondName)
        {
            this.ID = ID;
            this.name = Name;
            this.secondName = SecondName;
        }
        public string FullName
        {
            get { return this.name + " " + this.secondName; }
        }

        public void PublicationRecord(string record)
        {
            Console.WriteLine("Пользователь {0} написал: {1}", this.FullName, record);
        }

        public void RecordAlert(User person)
        {
            Console.WriteLine("Уважаемый {0}", this.FullName);
            Console.WriteLine("Записи пользователя {0} обновлены!", person.FullName);
        }

        public void RаteRecord(User user)
        {
            Console.WriteLine("Уважаемый {0} {1}", this.name, this.secondName);
            Console.WriteLine("Пост был оценен пользователем: {0}", user.FullName);
        }
    }    

}