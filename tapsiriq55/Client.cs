using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq55
{
    class Client
    {
        public Client(int id, string name, string surname, int age, int sallary, BankCard card)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sallary = sallary;
            this.card = card;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int sallary { get; set; }
        public BankCard card { get; set; }

        public void Show()
        {
            Console.WriteLine("id----"+id);
            Console.WriteLine("name----"+ name);
            Console.WriteLine("surname----"+ surname);
            Console.WriteLine("age----"+ age);
            Console.WriteLine("sallary----"+ sallary);
            card.Show();

        }
       
    }
}
