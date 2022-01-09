using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq55
{
    class BankCard
    {
        
        public string bankname { get; set; }
        public string fullname { get; set; }
    
        private string pan;

        public string Pan
        {
            get { return pan; }
            set
            {
                for (int i = 0; i < 16; i++)
                {
                    Random rnd = new Random();
                    pan += Convert.ToString(rnd.Next(0, 9));
                }
            }
        }
        
        private string pin;

        public string Pin
        {
            get { return pin; }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    Random rnd = new Random();
                    pin += Convert.ToString(rnd.Next(0, 9));
                }
            }
        }
        private string cvc;

        public BankCard(string bankname, string fullname, string expiredata, int balans)
        {
            this.bankname = bankname;
            this.fullname = fullname;
            Pan =pan;
            Pin = pin;
            Cvc = cvc;
            this.expiredata = expiredata;
            this.balans = balans;
        }

        public string Cvc
        {
            get { return cvc; }
            set
            {
                Random rnd = new Random();
                cvc = Convert.ToString(rnd.Next(100, 1000));
            }
        }

        public string expiredata { get; set; }

        public int balans { get; set; }
        public void Show()
        {
            Console.WriteLine("Bankname-----"+bankname);
            Console.WriteLine("Fullname-----"+ fullname);
            Console.WriteLine("Expiredata-----"+expiredata);
            Console.WriteLine("Balans-----"+balans);
            Console.WriteLine("Pan-----"+pan);
            Console.WriteLine("Pin-----"+pin);
            Console.WriteLine("Cvc-----"+cvc);
        }
        
        
       
    }
}
