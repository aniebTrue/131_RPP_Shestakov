using System;

namespace EventsSocialNet
{
    class UserAction
    {
        public void Alert()
        {
            Console.WriteLine("Тревога");
        }
    }
    ф

    class User
    {
        int ID;
        private string name, secondName;
        //private DateTime bDate;

        public delegate void MethodContainer();

        public event MethodContainer Alert;

        public User(int ID, string Name, string SecondName)
        {
            this.ID=ID;
            this.name=Name;
            this.secondName=SecondName;
        }
        public string FullName
        {
            get{return this.name+" "+this.secondName;}
        }

        public void PublicationRecord(string record)
        {
            Console.WriteLine("Пользователь {0} написал: {1}", this.FullName, record);
            if (Alert != null)
            {
                Alert();
            }
        }
        public void RevordAlert(User person)
        {
            Console.WriteLine("Уважаемый {0} {1}", this.name, this.secondName);
            Console.WriteLine("Записи пользователя {0} {1} обновлены!", person.name,person.secondName);
        }

        public void RаteRecord(User user)
        {
            Console.WriteLine("Уважаемый {0} {1}", this.name, this.secondName);
            Console.WriteLine("Пост был оценен пользователем: {0}",user.FullName);
        }
    }
}