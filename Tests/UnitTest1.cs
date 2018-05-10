using NUnit.Framework;
using SandroMancusoTraining_Project1;

namespace Tests
{
    [TestFixture]
    public class OurStackShould
    {
        [Test]
        public void HaveNoContent_WhenCreated() 
        {
            OurStack stack = new OurStack();

            Assert.IsNull(stack.Pop());
        }

        [Test]
        public void PopTheLastPushedObject()
        {
            OurStack stack = new OurStack();

            stack.Push("otroItem");
            stack.Push("item");

            Assert.AreEqual("item", stack.Pop());
        }
    }
}
