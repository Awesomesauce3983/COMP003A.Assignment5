/* Author: Anastasia Clements
 * Course: COMP003A
 * Purpose: Assignment 5 (Methods!! w/ comments) */
using System.Net.Cache;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeperator("Triangle");
            Console.Write("Please input height of triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input character constructing triangle: ");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
            IsoscelesTriangleBuilder(character, height);
            Console.WriteLine("\n");
            PrintSeperator("Favorite Characters");
            CharacterInfo("Basil (my cat)", 2020);
            CharacterInfo("Gimli", 1954);
            CharacterInfo("Mordenkainen", 2000);
            CharacterInfo("Gnome Child (RuneScape)", 2008);
            CharacterInfo("Liliana Vess", 2008);



        }

        /// <summary>
        /// Writes a seperator
        /// </summary>
        static void PrintSeperator() 
        {
            Console.WriteLine("".PadRight(50, '='));
        }
        
        /// <summary>
        /// Writes a header between seperators
        /// </summary>
        /// <param name="label">Title of header</param>
        static void PrintSeperator(string label)
        {
            PrintSeperator();
            Console.WriteLine($"{label}".PadLeft(25 + label.Length/2,' '));
            PrintSeperator();
        }

        /// <summary>
        /// Writes an Isosceles Triangle
        /// </summary>
        /// <param name="inputCharacter">Character</param>
        /// <param name="size">Height</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("".PadRight(i + 1, inputCharacter));
            }
           
            for(int i = size; i > 1; i-- )
            {
                Console.WriteLine("".PadRight(i-1, inputCharacter));
            }
        }

        /// <summary>
        /// Calculates Age based on current year
        /// </summary>
        /// <param name="year">year</param>
        /// <returns></returns>
        static int AgeCalculator(int year) 
        {
            return DateTime.Now.Year - year;
        }

        /// <summary>
        /// Writes a name and their age to the current year
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="birthYear">Birth Year</param>
        static void CharacterInfo(string name, int birthYear) 
        {
            Console.WriteLine($"{name} is {AgeCalculator(birthYear)} years old!");
        }
    }
}