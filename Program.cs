using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace task5
{

    class task5
    {
        static void Main()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the numbers separated by spaces");
            string input;
            string[] Array;
            try
            {
                input = Console.ReadLine();
                Array = input.Split(' ');
                bool found = false;
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = i + 1; j < Array.Length; j++)
                    {

                        if (int.Parse(Array[i]) == int.Parse(Array[j]))
                        {
                            found = true;
                            break;
                        }
                    }
                    break;

                }
                if (!found)
                {
                    foreach (string num in Array)
                    {
                        list.Add(int.Parse(num));
                    }
                    Console.WriteLine("All numbers are unique");
                }
                if (found)
                {
                    throw new ArgumentException("Sorry,duplicated found");
                }
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exeption: {ex.Message}");
            }

        }
    }
}
