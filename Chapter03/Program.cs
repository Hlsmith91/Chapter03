using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Heather Smith CITC -1312

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            Exercise05();

            Console.ReadKey();
        }

        private static void Exercise05()
        {
            String employeeName;
            Console.WriteLine("Please enter employee name : ");
            employeeName = Console.ReadLine();
            double sales = checkInputDouble("Enter your weekly sales: ");
            double commissionRate = .07;
            double salesCommission = sales * commissionRate;

            double retirementRate = .15;
            double retirementTake = salesCommission * retirementRate;
            double fedRate = .18;
            double fedTake = (salesCommission - retirementTake) * fedRate;
            double ssRate = .09;
            double ssTake = salesCommission * ssRate;

            double totalDeductions = fedTake + retirementTake + ssTake;
            double takeHome = salesCommission - totalDeductions;

            Console.WriteLine("{0}", employeeName);
            Console.WriteLine("Total Sales: {0:C}", sales);
            Console.WriteLine("Commission: {0:C}", salesCommission);
            Console.WriteLine("Deductions: ");
            Console.WriteLine("Fed Take: {0:C}", fedTake);
            Console.WriteLine("Retirement Take: {0:C}", retirementTake);
            Console.WriteLine("Social Security Take: {0:C}", ssTake);
            Console.WriteLine("Total Deductions: {0:C} ", totalDeductions);
            Console.WriteLine("Take Home: {0:C} ", takeHome);
        }

        public static void Exercise04()
        {
            double charge = checkInputDouble("Please enter total: ");
            double tip = checkInputDouble("Please enter tip percentage: ");
            double taxes = .09;

            if (tip >= 1.0)
            {
                tip /= 100;
            }

            double taxPaid = charge * taxes;
            double tipPaid = charge * tip;
            double totalPaid = charge + tipPaid + taxPaid;

            Console.WriteLine("\nMeal Price\t{0}\nTaxes\t\t{1}\nTip\t\t{2}\nTotal\t\t{3}",
                charge, taxPaid, tipPaid, totalPaid);
        }

        public static void Exercise03()
        {
            int seconds = CheckInputInt("Enter number of seconds.");
            secondsToHMS(seconds);
        }

        private static void secondsToHMS(int seconds)
        {
            
            int h = seconds / 3600;
            int m = seconds % 3600 / 60;
            int s = seconds % 3600 % 60;
            Console.WriteLine("Hours/Minute/Seconds {0}/{1}/{2}", h, m, s);
        }

        private static void Exercise02()
        {
            double height = checkInputDouble("Enter the height of rectange: ");
            double width = checkInputDouble("Enter the width of rectange: ");
            double area = height * width;
            double perimeter = 2.0 * height + 2.0 * width;
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine("Height\t\t{0}\nWidth\t\t{1}\nArea\t\t{2}\nPerimeter\t{3}", height, width, area, perimeter);

            double angle = Math.Atan2(height, width) * (180 / Math.PI);
           // Console.WriteLine("Height\t\t{0}\nWidth\t\t{1}\nArea\t\t{3}\nPerimeter\t\t{4}\nDiagonal\t\t{4}\n", height, width, area, perimeter, diagonal);

        }

        public static int CheckInputInt(string message)
        {
            int retVal = 0;
            string inputString = "";
            Console.WriteLine(message);
            inputString = Console.ReadLine();
            while(!int.TryParse(inputString, out retVal) == true)
                {
                Console.WriteLine(message);
                inputString = Console.ReadLine();
            }
            return retVal;
        }

        public static double checkInputDouble(string message)
        {
            double retVal = 0.0;
            string inputString = "";
            Console.WriteLine(message);
            inputString = Console.ReadLine();
            while (!double.TryParse(inputString, out retVal) == true)
            {
                Console.WriteLine(message);
                inputString = Console.ReadLine();
            }
            return retVal;
        }

        private static void Exercise01()
        {
            string inputString = "";
            inputString = AskFor("name", "Enter Name:");
            Console.WriteLine("Your name is " + inputString);
            inputString = AskFor("saying", "Enter favorite saying");
            Console.WriteLine("Your favorite saying is: " + inputString);
        }

        private static string AskFor(string v1, string v2)
        {
            string retVal = "";
            Console.WriteLine(v2);
            retVal += Console.ReadLine();
            if(v1 == "saying")
            {
                retVal = "<<<<<" + retVal + ">>>>>";
            }
            return retVal;
        }

       
    }
}
