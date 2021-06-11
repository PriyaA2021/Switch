using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter number between 1-4");
            a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                
                    Console.WriteLine("You chose number 1");
                break;
                case 2:
                
                    Console.WriteLine("You chose number 2");
                    break;
                
                case 3:
                
                    Console.WriteLine("You chose number 4");
                    break;

            case 4:
                
                Console.WriteLine("You chose number 4");
                break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        }
    }

