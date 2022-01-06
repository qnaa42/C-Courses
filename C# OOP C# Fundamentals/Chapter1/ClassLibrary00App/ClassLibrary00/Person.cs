using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public abstract float ComputeGradeAvarage();

        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dear " + firstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
        }
    }
}
