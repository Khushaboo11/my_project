using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Oops_concept
{
    class BankDetails
    {
        public long acc_num;
        public string acc_type;
        public string cus_name;
        public long bal;
        public long total_bls;
        public void input(long acn,string acctype,string cusname,long balance) 
        {
            acc_num = acn;
            acc_type = acctype;
            cus_name = cusname;
            bal = balance;

        }
        void display()
        {
            Console.WriteLine(" account number "+acc_num);
            Console.WriteLine(" account type "+acc_type);
            Console.WriteLine(" customer name "+cus_name);
            Console.WriteLine(" balance "+bal);
        }
        void WithOrDeposit()
        {
            Console.WriteLine(" welcome to my bank \n what you want to do 1.withdraw 2.deposit");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("enter the amount you want to withdraw");
                long amt = long.Parse(Console.ReadLine());
                long total_bls = bal + amt;
                Console.WriteLine("Avilable balance is = " + total_bls);

            }
            else
            {
                
                if (total_bls > 500)
                {
                    Console.WriteLine("enter the amount you want to deposit");
                    long amt = long.Parse(Console.ReadLine());
                    long total_bls = bal - amt;
                    Console.WriteLine("Avilable balance is = " + total_bls);
                }
                else
                {
                    Console.WriteLine(" oops you have low balance in your account");
                }

            }
        }
        static void Main(string[] args)
        {
            BankDetails a = new BankDetails();
            a.input(9045678311001, "withdraw", "khushi",50000);
            a.display();
            a.WithOrDeposit();
        }


    }
}
