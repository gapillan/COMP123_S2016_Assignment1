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

        static void Main(string[] args)
        {
         // create instance of the Hero class 
            Hero Saitama = new Hero("Master Saitama ");
            Console.WriteLine();
            Saitama.Strength = 90;
            Saitama.Speed = 80;
            Saitama.Health = 100; 

            Saitama.Show();
        }
    }
}
