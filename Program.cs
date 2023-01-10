namespace Find_Maximum_Problem_Using_Ganerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Find Maximum Using Generice!");
            //UC1 - Maximum int Number
            //Test Case 1 - Max Number at first position and return same. 
            int maxInt = UC1FindMaxT.FindIntMaximum(32, 18, 11);
            Console.WriteLine("Maximum Numbe is : " + maxInt);

            //Test Case 2 - Max Number at Second position and return same. 
            int max2ndInt = UC1FindMaxT.FindIntMaximum(18, 32, 11);
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndInt);

            double max2ndDouble = FindMax.FindDoubleMaximum(42.45, 55.85, 23.25);
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndDouble);

            //Float :  Test case 1 - Max at First Position 
            double max1Float = FindMaximum<double>.testMaximum(40.23, 20.34, 35.45, 20.44, 44.56);
            Console.WriteLine("\nMaximum Number for 1st float test Case is : " + max1Float);
            //Float : Test case 2 - Max at Second Position 
            double max2Float = FindMaximum<double>.testMaximum(20.34, 40.23, 35.45, 20.44, 44.56);
            Console.WriteLine("Maximum Number for 2nd float test Case is : " + max2Float);
            //Float : Test case 3 - Max at third Position 
            double max3Float = FindMaximum<double>.testMaximum(20.34, 35.45, 40.23, 20.44, 44.56);
            Console.WriteLine("Maximum Number for 3rd float test Case is : " + max3Float);

            String max1stString = FindMax.FindStringMaximum("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum Number for 1st test Case is : " + max1stString);
            //Test Case 2 - Max string at Second position and return same. 
            String max2ndString = FindMax.FindStringMaximum("Peach", "Apple", "Banana");
            Console.WriteLine("Maximum Number for 2nd test Case is : " + max2ndString);
            //Test Case 3 - Max string at Third position and return same. 
            String max3rdString = FindMaxi.FindStringMaximum("Peach", "Banana", "Apple");
            Console.WriteLine("Maximum Number for 3rd test Case is : " + max3rdString);
            static void Main(string[] args)
            {
                //Welcome Message
                Console.WriteLine("Welcome to Maximum Number");

                int[] intArray = { 34, 23, 12, 36 };
                double[] doubleArray = { 12.5, 45.65, 987.45, 658.78 };
                string[] stringArray = { "Apple", "Peach", "Banana" };

                // Passing integer input with max number at first place
                ExtendGenericMaximum<int> extendGenericMaximum = new ExtendGenericMaximum<int>(intArray);
                int outputInt = extendGenericMaximum.MaxMethod();

                ExtendGenericMaximum<double> extendGenericMaximum1 = new ExtendGenericMaximum<double>(doubleArray);
                double outputDouble = extendGenericMaximum1.MaxMethod();

                ExtendGenericMaximum<string> extendGenericMaximum2 = new ExtendGenericMaximum<string>(stringArray);
                string outputString = extendGenericMaximum2.MaxMethod();


                //Display Output
                Console.WriteLine("Integer Max : " + outputInt);
                Console.WriteLine("Float Max : " + outputDouble);
                Console.WriteLine("String Max : " + outputString);

                Console.ReadLine();

                //Test Case 3 - Max Number at Third position and return same. 
                int max3rdInt = FindMaxi.FindIntMaximum(18, 11, 32);
                Console.WriteLine("Maximum Number for 3rd test Case is : " + max3rdInt);
                double max3rdDouble = FindMax.FindDoubleMaximum(23.25, 42.45, 55.85);
                Console.WriteLine("Maximum Number for 3rd test Case is : " + max3rdDouble);
            }
        }

    }
}
