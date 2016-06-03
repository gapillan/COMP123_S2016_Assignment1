using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Hero Saitama = new Hero("Master Saitama");
            Saitama.Show();
        }
    }
}
