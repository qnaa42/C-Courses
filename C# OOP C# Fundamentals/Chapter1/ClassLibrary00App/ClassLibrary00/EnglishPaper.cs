using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary00
{
    class EnglishPaper : IScored
    {
        public string title { get; set; }
        public int minimumWordCount { get; set; }
        public string paperText { get; set; }
        public float score { get; set; }
        public float maximumScore { get; set; }
        public int WordCount
        {
            get { return paperText.WordCount(); }
        }
    }
}
