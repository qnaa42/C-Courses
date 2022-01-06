using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    class PowerController : IPowerOn
    {
        //Other classes in namespace can get this variable, but cannot set it (half public variable). This class can stil set it as it would be public
        public bool isOn { get; private set; }

        //Encapsulated methods
        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        //Access for other classes to protected methods
        public virtual void TogglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else if (!isOn)
            {
                TurnOn();
            }
        }
    }
}
