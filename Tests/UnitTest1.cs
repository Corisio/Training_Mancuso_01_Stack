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
    }
}
