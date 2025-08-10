namespace taskLec5._1
{
 

   
   
        class Program
        {
            static List<int> numbers = new List<int>();

            static void PrintNumbers()
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("The list is empty");
                }
                else
                {
                    Console.WriteLine("Numbers in the list:");
                    foreach (int  i in numbers)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void AddNumber()
            {
                Console.Write("Enter your number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                numbers.Add(x);
                Console.WriteLine($"{x} added.");
            }

            static void DisplayMean()
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }
                double mean = (double)numbers.Sum() / numbers.Count;
                Console.WriteLine($"Mean: {mean}");
            }

            static void DisplaySmallest()
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }
                Console.WriteLine($"Smallest number: {numbers.Min()}");
            }

            static void DisplayLargest()
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }
                Console.WriteLine($"Largest number: {numbers.Max()}");
            }

            static void Main(string[] args)
            {
                char choice;
                do
                {
                    Console.WriteLine("\nP - Print numbers");
                    Console.WriteLine("A - Add a number");
                    Console.WriteLine("M - Display mean of the numbers");
                    Console.WriteLine("S - Display the smallest number");
                    Console.WriteLine("L - Display the largest number");
                    Console.WriteLine("Q - Quit");

                    Console.Write("Enter your choice: ");
                    choice = Convert.ToChar(Console.ReadLine().ToLower());

                    switch (choice)
                    {
                        case 'p':
                            PrintNumbers();
                            break;
                        case 'a':
                            AddNumber();
                            break;
                        case 'm':
                            DisplayMean();
                            break;
                        case 's':
                            DisplaySmallest();
                            break;
                        case 'l':
                            DisplayLargest();
                            break;
                        case 'q':
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Unknown option. Please try again.");
                            break;
                    }

                } while (choice != 'q');
            }
        }
    }


