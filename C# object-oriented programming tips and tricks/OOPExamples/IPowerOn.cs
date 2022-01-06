using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExamples
{
    interface IPowerOn
    {
        bool isOn { get; }
        void TogglePower();
    }
}
