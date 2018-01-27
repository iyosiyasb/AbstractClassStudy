using System;

namespace AbstractClasstut
{
    class Program
    {
        public static void Main()
        {
            FullTimeemp fte = new FullTimeemp()
            {
                Id = 101,
                FirstName = "josh",
                LastName = "wolde",
            AnnualSalary = 50000,

            };
        Console.WriteLine(fte.GetFullName());
        Console.WriteLine(fte.GetMonthlySalary());
        Console.WriteLine("=============");
            Console.ReadLine();
           



            Contractemp cte = new Contractemp()
            {
                Id = 102,
                FirstName = "Abush",
                LastName = "Beyene",
                HourlyPay = 500,
                TotalHours = 40,

            };
    Console.WriteLine(cte.GetFullName());
        Console.WriteLine(cte.GetMonthlySalary());
        Console.WriteLine("=============");
            Console.ReadLine();


        }
}
}



