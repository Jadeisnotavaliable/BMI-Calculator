using System;

namespace BMI_Calculator
{
    class Program
    {


        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
                
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("City Gym");
            Console.WriteLine();
            Console.WriteLine("1) Membership Options");
            Console.WriteLine("2) BMI Calclator");
            Console.WriteLine();
            Console.Write("Select an option: ");
            
             
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    MembershipOptions();
                   
                    return true;
                    
                case "2":
                    Console.Clear();
                    BMI_Calculator();
                    
                    return true;
                default:

                    return true;

                  

            }
        }
        static void MembershipOptions()
        {
            string basic = " Basic membership is $10 ";
            string regular = " regular membership is $15";
            string premium = "Premium membership is $20";

            Console.WriteLine(" Select a membership");
            Console.WriteLine();
            Console.WriteLine(" 1) Basic ");
            Console.WriteLine(" 2) Regular ");
            Console.WriteLine(" 3) Premium ");
            Console.WriteLine(" 4) Return to main menu");
            switch (Console.ReadLine())
            {
               
                case "1":
                    Console.Clear();
                    Console.WriteLine(basic);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(regular);
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(premium);
                    break;
                case "4":
                    MainMenu(); 
                    break;
            }
        }

        
        private static void BMI_Calculator()
        {
         
            Console.WriteLine(" Enter your weight (kg) : ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter your height (m) : ");
            double m = Convert.ToDouble(Console.ReadLine());
            double BMI = kg / (m * m);

            if (BMI < 18.5)
               
                Console.WriteLine("  Your BMI is " + Math.Round(BMI) + " you are underweight ");
               
            else
                if (BMI is < 25)
                Console.WriteLine(" Your BMI is " + Math.Round(BMI) + " you are a healthy weight ");
            else
                if (BMI is < 30)
                Console.WriteLine(" Your BMI is " + Math.Round(BMI) + " you are overweight");
            else
                if (BMI is > 30)
                Console.WriteLine(" Your BMI is " + Math.Round(BMI) + " you are obese ");

            

            Console.ReadKey();
        }

    }
}


           


