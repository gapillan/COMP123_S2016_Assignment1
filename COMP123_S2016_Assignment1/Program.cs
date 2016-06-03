using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author's Name: Golden Pamela Apillanes
 * Author's Student Number: 300867201
 * Date Modified: June 2nd 2016 
 * Program Description: Implementing the Hero class
 * Revision History: June 2nd 2016 
 */

namespace COMP123_S2016_Assignment1
{
        /**
        * This class is the "driver" class for the Program 
        * 
        * @class Program 
        */
    class Program
    {
        /**
         * The main method of our driver class Program 
         * 
         * @method Main 
         * @param {string[]} args
         */

        public static void Main(string[] args)
        {

            Console.WriteLine("          Hero Class - Assignment 1 "); 

         // create instance of the Hero Saitama 
            Hero Saitama = new Hero(" Saitama ");
            Console.WriteLine();
            Saitama.Strength = 110;
            Saitama.Speed = 110;
            Saitama.Health = 100; 

            Saitama.Show();
            Saitama.Fight(true);

            // create instance for Hero Genos
            Hero Genos = new Hero(" Genos");
            Console.WriteLine();
            Genos.Strength = 80;
            Genos.Speed = 90;
            Genos.Health = 100;

            Genos.Show();
            Genos.Fight(false);

           // generateAbilitiesToConsole();
            
        }

        //public static string generateAbilitiesToConsole() 
        //{
        //    string generateAbilitiesString = "";
        //    Console.WriteLine(generateAbilitiesString);
        //    return generateAbilitiesString;
        //}
    }
}
