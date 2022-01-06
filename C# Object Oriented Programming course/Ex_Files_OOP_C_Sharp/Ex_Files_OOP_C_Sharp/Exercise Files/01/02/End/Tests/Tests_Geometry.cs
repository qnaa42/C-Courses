using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Test_Geometry
    {
        [TestMethod]
        public void Tests_001_Geometry()
        {
            Square s = new Square();
            s.Width = 10;

            Rectangle r = new Rectangle();
            r.Width = 20;
            r.Height = 30;
        }
    }
    public class Polygon
    {
        // arbitrary number of edges
    }
    public class Rectangle
    {
        public virtual uint Width { get; set; }
        public uint Height { get; set; }
    }
    public class Square // : Rectangle
    {
        public uint Width { get;set;} // new or override or ... 
    }
}
