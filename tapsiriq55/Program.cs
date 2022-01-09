using System;
using System.Text;
using System.Threading;
using tapsiriq55;

string Date()
{
    return Convert.ToString(DateTime.Now);
}

BankCard card1 = new("MoneyBank", "hasan", Date(), 0);
BankCard card2 = new("MoneyBank", "hasan", Date(), 50);
BankCard card3 = new("MoneyBank", "hasan", Date(), 50);
BankCard card4 = new("MoneyBank", "hasan", Date(), 50);
BankCard card5 = new("MoneyBank", "hasan", Date(), 50);

/////////////////////////////////////////////////////////////////
Client client1 = new(1, "hasan", "rzayev", 19, 5000, card1);
Client client2 = new(1, "hasan", "rzayev", 19, 4000, card2);
Client client3 = new(1, "hasan", "rzayev", 19, 3000, card3);
Client client4 = new(1, "hasan", "rzayev", 19, 2000, card4);
Client client5 = new(1, "hasan", "rzayev", 19, 1000, card5);
/////////////////////////////////////////////////////////////////
Bank moneybank = new("MoneyBank");
moneybank.Add(client1);
moneybank.Add(client2);
moneybank.Add(client3);
moneybank.Add(client4);
moneybank.Add(client5);
/////////////////////////////////////////////////////
Console.OutputEncoding = System.Text.Encoding.UTF8;

Encoding unicode = Encoding.Unicode;

var choose = 0;
string pin;
string pan;
int number;
int number1;
int money;
while (true)
{
    moneybank.Show();
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\u263A  " + "Xos gelmisiniz"+  "  \u263A  ");
    Console.WriteLine("Pin daxil edin.....");
    pin = (Console.ReadLine());
    if (moneybank.Checkpin(pin) == -1)
    {
        Console.WriteLine("Duzgun daxil edin !!!");
        continue;
    }
    number = moneybank.Checkpin(pin);
    Console.Clear();
    Console.WriteLine("Xos gelmisiniz !!!");
    moneybank.clients[number].Show();
    Console.WriteLine("Balans");
    Console.WriteLine("Nagd Pul");
    Console.WriteLine("Pul Kocurme");
    choose = Convert.ToInt32(Console.ReadLine());
    if (choose == 1)
    {
        Console.Clear();
        Console.WriteLine(moneybank.clients[number].card.balans);
         
    }
    else if (choose == 2)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Goturmek istediyniz meblegi daxil edin");
            Console.WriteLine("1-------10");
            Console.WriteLine("2-------20");
            Console.WriteLine("3-------50");
            Console.WriteLine("4-------100");
            Console.WriteLine("5-------Reqemi ozunuz daxil edin");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                money = 10;
            }
            else if (choose == 2)
            {
                money = 20;
            }
            else if (choose == 3)
            {
                money = 50;
            }
            else if (choose == 4)
            {
                money = 100;
            }
            else if (choose == 5)
            {
                Console.WriteLine("Istediyinizi daxil edin");
                money = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Duzgun daxil edin !!!");
                continue;

            }
            try
            {
                moneybank.MoneyDecrement(number, money);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
                Thread.Sleep(1000);
            }
        }
        
    }
    else if (choose == 3)
    {
        Console.WriteLine("Kocurme etmek istediyniz pani daxil edin");
        pan = (Console.ReadLine());
        if (moneybank.CheckPan(pan) == -1)
        {
            Console.WriteLine("Bu pan koda aid  yoxdur  !!!");
            Thread.Sleep(1000);
            continue;
        }
        number1 = moneybank.CheckPan(pan);
        Console.WriteLine("Ne qeder mebleg");
        money = Convert.ToInt32(Console.ReadLine());
        try
        {
            moneybank.MoneyDecrement(number, money);
        }
        catch (IndexOutOfRangeException ex)
        {

            Console.WriteLine(ex.Message);
            Thread.Sleep(1000);
        }
        moneybank.Transfer(number, number1, money);





    }

}
