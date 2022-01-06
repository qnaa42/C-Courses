using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    class ScienceExperiment : IScored
    {

        public string hypothesis { get; set; }
        public string materials { get; set; }
        public string method { get; set; }
        public string conclusion { get; set; }
        public float score { get; set; }
        public float maximumScore { get; set; }
    }
}
