using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq55
{
    class Bank
    {
        public Bank(string bankname)
        {
            this.bankname = bankname;
      
        }

        public string bankname { get; set; }
        public Client[] clients=new Client[] { };
        public void Add(Client c)
        {
            Array.Resize(ref clients, clients.Length + 1);
            clients[clients.Length - 1] = c;
        }

        public int Checkpin(string pin)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].card.Pin == pin)
                {
                    return i;
                }
            }
            return -1;
            //throw new ArgumentNullException(nameof(data), "gonderdiyivize baxin da bir!");
        }
        public int CheckPan(string pan)
        {
            for (int i = 0; i < clients.Length; i++)
            {
                if (clients[i].card.Pan == pan)
                {
                    return i;
                }
            }
            return -1;
            //throw new ArgumentNullException(nameof(data), "gonderdiyivize baxin da bir!");
        }
        public void Show()
        {
            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine("=================================");
                clients[i].Show();
                Console.WriteLine("=================================");
            }
           
        }
        public void MoneyDecrement(int number, int money)
        {
            if (clients[number].card.balans < money)
            {
                throw new IndexOutOfRangeException(" Balans bu qeder yoxdur  !!!");
            }
            clients[number].card.balans-=money;
        }
        public void Transfer(int number,int number1,int money)
        {
         
            clients[number1 ].card.balans += money;

        }
    }
}
