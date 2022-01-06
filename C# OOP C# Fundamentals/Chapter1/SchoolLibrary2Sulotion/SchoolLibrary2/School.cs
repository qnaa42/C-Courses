using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary2
{
    class School
    {
        //// <summary>
        //// Not Ecapsulated variables, you can get them from anywhere, and you can set to them to anything
        //// </summary>
        public string name { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public string schoolZip { get; set; }
        public string phoneNumber { get; set; }

        //// <summary>
        //// Ecapsulated variable, you can get it from anywhere (is public) but you can only set it to correct value (with @ at the begining)
        //// </summary>
        public string _twitterAdress;
        public string twitterAddress
        {
            //make sure the twitter adress strarts with @
            get { return _twitterAdress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAdress = value;
                }
                else if (!value.StartsWith("@"))
                {
                    throw new Exception("The twitter adress must begin with @");
                }
            }
        }


        //// <summary>
        //// Base Constructor
        //// </summary>
        public School()
        {
            name = "Untitled School";
            phoneNumber = "555-1234";
        }

        //// <summary>
        //// OverLoaded Contructed
        //// </summary>
        public School(string schoolName, string schoolPhoneNumber)
        {
            name = schoolName;
            phoneNumber = schoolPhoneNumber;
        }


        /// <summary>
        /// Base function to return float avarage value of 3 input
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="c">c</param>
        /// <returns></returns>
        //public float AvarageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}


        /// <summary>
        /// Function bodied expresion, return value as flot without method body, good for simple calculations and reurns
        /// </summary>
        public static float AvarageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        /// <summary>
        /// Overload version of base method where it return int value and take int as input
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <param name="c">c</param>
        /// <returns></returns>
        public static int AvarageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(name);
            sb.AppendLine(adress);
            sb.AppendLine(city);
            sb.Append(", ");
            sb.Append(schoolZip);
            return sb.ToString();
        }
    }
}

