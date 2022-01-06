using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class Tests_Imagination2
    {
        [TestMethod]
        public void Test_Imagination_02()
        {
            var sweeper = new Sweepable();
            var gallery = new ArtExhibit();
            var wallart = new Carpet();
        }
    }
    public class Carpet
    {
        public List<IAction> actions = new List<IAction>();
        public Carpet(params IAction[] possibleActions)
        {
            actions.AddRange(possibleActions);
        }
    }

    public interface IAction
    {
        void PerformAction();
    }
    public class Sweepable : IAction
    {
        public void PerformAction()
        {
            Sweep();
        }
        public void Sweep()
        {
        }
    }
    public class ArtExhibit : IAction
    {
        public void Exhibit()
        {

        }
        public void PerformAction()
        {
            Exhibit();
        }
    }
}