using System.Collections;

namespace Assignment_3
{
    internal class Program
    {
        void totalduplicate()
        {
            int[] arr = new int[] { 10, 30, 10, 20, 30, 50, 60 };

            Dictionary<int, int> count = new Dictionary<int, int>();
            
            foreach( int i in arr) 
            {
                if( count.ContainsKey(i) )
                    count[i]++;
                else
                    count.Add(i, 1);
            }

            foreach(var it in count)
            {
                if(it.Value > 1)
                    Console.WriteLine(it.Key+" ");
            }
        }

        void checkeligibility()
        {
            Console.WriteLine("Input the marks obtained in Physics");
            int physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics");
            int maths = Convert.ToInt32(Console.ReadLine());

            if(physics+chemistry+maths>=180 || (maths+physics)>=140)
            {
                Console.WriteLine("The candidate is eligible for admission.");

            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

        }
        void electricitybill()
        {
            Console.WriteLine("Enter customer id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter unit consumed");
            int units = Convert.ToInt32(Console.ReadLine());

            double bill = 0;
            double perunit=0;
            if(units<=199)
            {
                perunit = 1.20;
                bill = 1.20 * units;
            }
            else if(units>=200 && units<400)
            {
                perunit = 1.50;
                bill = 1.50 * units;
            }
            else if (units >= 400 && units < 600)
            {
                perunit = 1.80;
                bill = 1.80 * units;
            }
            else if(units>=600)
            {
                perunit = 2.00;
                bill = 2.00 * units;
            }
            double surcharge=0;
            if(bill>400)
            {
                surcharge = bill * 0.15;
            }
            if (bill < 100)
                bill = 100;

            Console.WriteLine("Customer IDNO :" + id);
            Console.WriteLine("Customer Name :" + name);
            Console.WriteLine("unit Consumed :" + units);
            Console.WriteLine($"Amount Charges @Rs. {perunit} per unit : {bill}");
            Console.WriteLine("Surchage Amount :" + surcharge);
            Console.WriteLine("Net Amount Paid By the Customer :" + (surcharge+bill));

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            
            program.electricitybill();
            
        }
    }
}