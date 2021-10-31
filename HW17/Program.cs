using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите параметры счёта:\nВведите номер счёта:");
            //string input = Console.ReadLine();
            //var Accountnumber;
            //if (decimal.TryParse(input, out decimal number))
            //    Accountnumber = number;
            //else
            //    Accountnumber = input;
            ////int Accountnumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите значение угловых минут:");
            //double Cash = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите значение угловых секунд:");
            //string Name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Вы ввели угол: {0} градусов, {1} минут, {2} секунд", Accountnumber, Cash, Name);
            ////Console.ReadKey();
            ////Angle angle = new Angle();
            //Account<int> account = new Account<int>(12, 25.13, "Сидоров Иван Иванович");
            //Account<string> account2 = new Account<string>("05А1", 25.13, "Сидоров Иван Иванович");

            Account<int> account = new Account<int>(12, 25.13, "Сидоров Иван Иванович");
            Account<string> account2 = new Account<string>("05А1", 25.13, "Сидоров Иван Иванович");
            account.Info();
            account2.Info();
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T accountnumber;
        private double cash;
        private string name;
        public T Accountnumber
        {
            set
            {
                accountnumber = value;
            }
            get
            {
                return accountnumber;
            }
        }
        public double Cash
        {
            set
            {
                cash = value;
            }
            get
            {
                return cash;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public Account(T accountnumber, double cash, string name)
        {
            this.Accountnumber = accountnumber;
            this.Cash = cash;
            this.Name = name;
        }   
        public void Info()
        {
            Console.WriteLine($"Номер счёта: {accountnumber}, баланс: {cash}, ФИО: {name}");
        }


    }
}
