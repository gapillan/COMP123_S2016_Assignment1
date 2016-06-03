﻿using System;
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




        // ++++++++++++++++++++++ CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++

        // ++++++++++++++++++++++ PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++
    }
}
