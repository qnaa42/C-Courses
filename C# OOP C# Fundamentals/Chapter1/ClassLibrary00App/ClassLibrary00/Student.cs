using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Spohmore, Junior, Senior}
        public GradeLevels gradeLevel { get; set; }

        public override float ComputeGradeAvarage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This is message is private and confidential");
            return sb.ToString();
        }
    }
}
