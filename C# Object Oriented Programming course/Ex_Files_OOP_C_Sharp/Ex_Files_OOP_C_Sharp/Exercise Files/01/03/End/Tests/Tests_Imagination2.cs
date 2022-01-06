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

            var wallart = new Carpet(sweeper, gallery);

            foreach (var action in wallart.Actions)
            {
                action.PerformAction();
            }
        }
    }
    public class Carpet
    {
        public List<IAction> Actions = new List<IAction>();

        public Carpet(params IAction[] possibleActions)
        {
            this.Actions.AddRange(possibleActions);
        }
    }
    public interface IAction
    {
        void PerformAction();
    }
    public class Sweepable : IAction
    {
        public void Sweep()
        {
            // TODO
        }
        public void PerformAction()
        {
            this.Sweep();
        }
    }
    public class ArtExhibit : IAction
    {
        public void Exhibit()
        {
            // TODO
        }
        public void PerformAction()
        {
            this.Exhibit();
        }
    }
}