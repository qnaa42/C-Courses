using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Tests
{
    [TestClass]
    public class Tests_NetFramework
    {
        [TestMethod]
        public void Test_001()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.IsTrue(numbers is IEnumerable<int>);

            var e = numbers.GetEnumerator();
            Assert.IsTrue(e is IEnumerator<int>);

            bool hasData = e.MoveNext();
            Assert.IsTrue(hasData);

            int i = e.Current;
            Assert.IsTrue(i == 1);
        }
        [TestMethod]
        public void Test_002()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.IsTrue(numbers is IEnumerable<int>);

            var e = numbers.GetEnumerator();
            Assert.IsTrue(e is IEnumerator<int>);

            while (e.MoveNext())
            {
                int i = e.Current;
                Debug.WriteLine($"{nameof(Test_002)}::{nameof(i)}::{i}");
            }
        }
        [TestMethod]
        public void Test_003()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.IsTrue(numbers is IEnumerable<int>);

            foreach (var i in numbers)
            {
                Debug.WriteLine($"{nameof(Test_003)}::{nameof(i)}::{i}");
            }
        }
        [TestMethod]
        public void Test_004()
        {
            var a = new int[] { 1, 3, 5, 7, 11 };
            Assert.IsTrue(a is IEnumerable<int>);
            Assert.IsTrue(a is IList<int>);

            var l = new List<int>() { 1, 3, 5, 7, 11 };
            Assert.IsTrue(l is IEnumerable<int>);
            Assert.IsTrue(l is IList<int>);
        }

        static string filename = @"..\..\..\..\..\..\..\Environmental_Data_Deep_Moor_2012.txt";

        [TestMethod]
        public void Test_010_FileStream()
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            var b1 = fs.ReadByte();
            var c1 = (char)b1;
            Assert.IsTrue(c1 == 'd');

            fs.Close();
        }
        [TestMethod]
        public void Test_011_FileStream()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.IsTrue(c1 == 'd');
            }
            finally
            {
                fs?.Close();
            }
        }
        [TestMethod]
        public void Test_012_FileStream()
        {
            FileStream fs = null;
            IDisposable idfs = fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.IsTrue(c1 == 'd');
            }
            finally
            {
                idfs?.Dispose();
            }
        }
        [TestMethod]
        public void Test_013_FileStream()
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            //FileStream fs = null;
            //IDisposable idfs = fs;
            //try
            {
                //fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.IsTrue(c1 == 'd');
            }
            //finally
            //{
            //    idfs?.Dispose();
            //}
        }
    }
}
