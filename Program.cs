using System;

namespace hackerv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] P = new Person[100];
            for (int x = 0; x < P.Length; x++)
            {
                P[x] = new Person();
            }                               

            int index = 0;

            bool shouldContinue = true;
            while (shouldContinue == true)
            {
                string option = string.Empty;
                Console.WriteLine("Please enter option");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please sign up");
                        Console.WriteLine("Name");
                        P[index].Name = Console.ReadLine();
                        Console.WriteLine("Age");
                        int.TryParse(Console.ReadLine(), out int result);
                        P[index].Age = result;
                        index++;
                        break;

                    case "2":
                        Console.WriteLine("Please Login");
                        Console.WriteLine("Name");
                        string nameInput = Console.ReadLine();

                        for (int x = 0; x < index; x++)
                        {
                            if (nameInput == P[x].Name)
                            {
                                Console.WriteLine("Success");

                            }
                            else
                            {
                                Console.WriteLine("Failed");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Deposit");
                        Console.WriteLine("Enter the amount you want to deposit");
                        float.TryParse(Console.ReadLine(), out float result1);
                        P[index].Deposit(result1);


                        break;

                    case "4":
                        Console.WriteLine("Withdraw");
                        Console.WriteLine("Enter the amount you want to withdraw");
                        float.TryParse(Console.ReadLine(), out float result2);
                        P[index].Withdraw(result2);
                        break;

                    case "5":
                        Console.WriteLine("Check Balance");
                        Console.WriteLine($"{P[index].Money}");
                        break;

                   
                    case "X":
                        Console.WriteLine("Exit");
                        Console.ReadKey();
                        shouldContinue = false;
                        break;

                    default:
                        Console.WriteLine("choose only 1-6");
                        Console.ReadKey();
                        break;




                }

            }

        }







    }
}
