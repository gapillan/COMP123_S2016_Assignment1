using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment1
{
    /**
     * <summary>
     * This class defines a Hero with special abilities  
     * </summary> 
     * 
     *@class Hero 
     */

    class Hero
    {
        // ++++++++++++++++++++++ PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++
        private string _name;
        private int _strength;
        private int _speed;
        private int _health; 

        // ++++++++++++++++++++++ PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++
        
        /**
         * <summary>
         * This is a public property for our private _name field 
         * </summary>
         * @property {string} Name
         */
        public string Name 
        {
            get 
            {
                return this._name; 
            }
            set 
            {
                this._name = value;
            }
        }

        /**
         * <summary>
         * This is a public property for our private _strength field 
         * </summary>
         * @property {int} Strength
         */
        public int Strength
        {
            get
            {
                return this._strength;
            }
            set
            {
                this._strength = value;
            }
        }

        /**
         * <summary>
         * This is a public property for our private _speed field 
         * </summary>
         * @property {int} Speed
         */
        public int Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
         * <summary>
         * This is a public property for our private _health field 
         * </summary>
         * @property {int} Health
         */
        public int Health
        {
            get
            {
                return this._health;
            }
            set
            {
                this._health = value;
            }
        }
        /**
         * <summary>
         * This is a public property for our public Fight field 
         * </summary>
         * 
         * @property {bool} hitAttempt 
         */
        public bool hitAttempt 
        {
            get 
            {
                return hitAttempt;
            }
            set 
            {
                hitAttempt = value;
            }
        }

        // ++++++++++++++++++++++ CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is a constructor that takes Hero as a parameter and passes 
         * it to the _name private instance variable 
         * </summary>
         * 
         * @contructor Hero
         * @param {string} name
         */
        public Hero(string Name) 
        {
            this._name = Name;
        }

        // +++++++++++++++++++++ PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++

        /**
         * <summary> 
         * This method takes strength, speed and health parameters. 
         * It assigns the local strenght value to the Strength property.
         * It assigns the local speed value to the Speed property. 
         * It assigns the local health value to the Health property.
         * </summary>
         * 
         * @private 
         * @method _generateAbilities 
         * @returns {void}
         */
        private void _generateAbilities(int strength, int speed, int health) 
        {
            this.Strength = strength;
            this.Speed = speed;
            this.Health = health; 
        }

        /**
         * <summary>
         * This method output calls the private hitAttempt property.
         * </summary> 
         * 
         * @method Fight() 
         * @returns {void} 
         */
        public void Fight()
        {
            if (hitAttempt == true) 
                this._hitDamage(2);
        }

        /**
         * <summary>
         * This method will determine if the Hero hits 
         * </summary>
         * 
         * @private 
         * @method _hitAttempt 
         * @returns {void}
         */
        private void _hitAttempt(bool hitAttempt) 
        {
            if (hitAttempt == true)
            {
                hitAttempt = true;
            }
            else 
            {
                this._hitAttempt(false);
            }
        }

        /**
         * <summary>
         * This method calculates by multiplying the Hero's strength property 
         * by a number between 1 and 6 
         * </summary>
         * 
         * @private
         * @method _hitDamage 
         * @return void 
         */
        private void _hitDamage(int hitDamage) 
        {
            if (hitAttempt)
            {
                hitDamage = Strength *2;
            }
            else
            {
                this._hitDamage(5);
            }
            
        }

        // ++++++++++++++++++++++ PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++

        /**
         * <summary> 
         * This method outputs the _name, _strength, _speed, and _health values
         * in the following. 
         * </summary>
         * 
         * @method Show
         * @returns {void} 
         */
        public void Show()
        {
            Console.WriteLine(" Hero Class - Assignment 1 ");
            Console.WriteLine();
            Console.WriteLine("***************************");
            Console.WriteLine("      " + this.Name);
            Console.WriteLine("***************************");
            Console.WriteLine("       Strength: " + this.Strength);
            Console.WriteLine("        Speed: " + this.Speed);
            Console.WriteLine("       Health: " + this.Health);
            Console.WriteLine("***************************");
        }        
        
    }
}
