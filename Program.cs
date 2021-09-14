using System;

namespace CSharp_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            string[] list = {"Rick", "Joao", "Pedro"};
            // Search for Joao inside the list
            foreach (string i in list) {
                
                if (list[j] == "Joao") {
                    Console.WriteLine(list[j]);
                    break;
                }
               j++; 
            }
        }
    }
}
