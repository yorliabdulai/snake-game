// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        try {
            Console.Write("Enter the file path:");
            string filePath = Console.ReadLine();
            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                Console.WriteLine("\nFileContents: \n");
                Console.WriteLine(fileContents);
            }else
            {
                Console.WriteLine($"File not found at the specified path: {filePath}");
            }
        }catch (Exception ex)
        {
            Console.WriteLine($"An error occured: {ex.Message}");
        }
       
    }
    

    
}
