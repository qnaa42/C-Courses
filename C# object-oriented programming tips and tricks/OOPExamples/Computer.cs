using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    public abstract class Computer : IPowerOn
    {
        protected IPowerOn powerController { get; set; }

        public bool isOn 
        { 
            get
            {
                return powerController.isOn;
            }
        }

        //Encapsulation of variable ----- very important
        protected string _name = "Unknown";

        public virtual string name 
        { 
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        //Contructor -- comunicate with name to encapsulate and protect variable _name
        public Computer(string name)
        {
            this.name = name;
            powerController = new PowerController();
        }

        //Access for other classes to protected methods
        public virtual void TogglePower()
        {
            powerController.TogglePower();
        }



    }
}
