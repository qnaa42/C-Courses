using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    public interface IScored
    {
        float score { get; set; }
        float maximumScore { get; set; }
    }
}
