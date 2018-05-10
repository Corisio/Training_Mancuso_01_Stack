using System;
using NUnit.Framework;
using SandroMancusoTraining_Project1;

namespace Tests
{
    [TestFixture]
    public class OurStackShould
    {
        private OurStack stack;

        [SetUp]
        public void SetUp()
        {
            stack = new OurStack();
        }

        [Test]
        public void FailWhenPopingAfterJustCreated() 
        {
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Test]
        public void PopTheLastPushedObject()
        {
            stack.Push("otroItem");
            stack.Push("item");

            Assert.AreEqual("item", stack.Pop());
        }
    }
}
