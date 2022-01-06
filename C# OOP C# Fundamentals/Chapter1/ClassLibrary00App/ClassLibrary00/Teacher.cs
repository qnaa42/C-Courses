using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    public class Teacher : Person
    {
        public string subject { get; set; }
        public override float ComputeGradeAvarage()
        {
            return 0.0f;
        }
    }


}
