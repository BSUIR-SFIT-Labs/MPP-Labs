using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using TextSorterLib;
using TextSorterLib.Sorter;

namespace TextSorterConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            do
            {
                Console.WriteLine("Menu:\n" +
                                  "1. Generate file\n" +
                                  "2. Sort file\n" +
                                  "3. Exit\n");
                Console.Write("Enter the action number: ");

                int actionNumber;
                try
                {
                    actionNumber = int.Parse(Console.ReadLine() ?? string.Empty);
                }
                catch
                {
                    Console.WriteLine("Error: invalid character entered!");
                    Console.WriteLine("Press ENTER to end the program...");
                    Console.ReadLine();
                    return;
                }
   
                switch (actionNumber)
                {
                    case 1:
                        Console.Write("Enter the path to save the generated file: ");
                        string pathToSaveGeneratedFile = Console.ReadLine();
                        Console.Write("Enter the size of the generated file in GB: ");

                        int fileSizeInGb;
                        try
                        {
                            fileSizeInGb = int.Parse(Console.ReadLine() ?? string.Empty);
                        }
                        catch
                        {
                            Console.WriteLine("Error: invalid data entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }

                        stopWatch.Reset();
                        stopWatch.Start();

                        try
                        {
                            FileGenerator.GenerateRandomFile(pathToSaveGeneratedFile,
                                fileSizeInGb * 1024 * 1024 * 1024,
                                Encoding.Unicode);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Error: incorrect file path entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Console.WriteLine("Error: incorrect file path entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine($"Success! File generation time: {stopWatch.ElapsedMilliseconds}ms.\n");
                        break;
                    case 2:
                        Console.Write("Enter the path to the file you want to sort: ");
                        string pathToSourceFile = Console.ReadLine();
                        Console.Write("Enter the path to save the sorted file: ");
                        string pathToSortedFile = Console.ReadLine();

                        stopWatch.Reset();
                        stopWatch.Start();

                        var sorter = new Sorter();
                        try
                        {
                            sorter.Sort(pathToSourceFile, pathToSortedFile);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Error: incorrect file path entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Console.WriteLine("Error: incorrect file path entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("Error: incorrect file path entered!");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred while sorting! ERROR: {ex.Message}.");
                            Console.WriteLine("Press ENTER to end the program...");
                            Console.ReadLine();
                            return;
                        }

                        Console.WriteLine($"Success! File sorting time: {stopWatch.ElapsedMilliseconds}ms.\n");
                        break;
                    case 3:
                        Console.WriteLine("Press ENTER to end the program ...");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Error: a non-existent command has been introduced!\n");
                        break;
                }

            } while (true);
        }
    }
}
