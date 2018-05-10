using System;
using NUnit.Framework;
using SandroMancusoTraining_Project1;

namespace Tests
{
    [TestFixture]
    public class OurStackShould
    {
        private OurStack _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new OurStack();
        }

        [Test]
        public void ThrowAnExceptionWhenPopingWhileEmpty() 
        {
            Assert.Throws<EmptyStackException>(() => _stack.Pop());
        }

        [Test]
        public void PopTheLastPushedObject()
        {
            _stack.Push("otroItem");
            _stack.Push("item");

            Assert.AreEqual("item", _stack.Pop());
        }

        [Test]
        public void PopAllThePushedObjectsInReverseOrder()
        {
            _stack.Push("item1");
            _stack.Push("item2");
            _stack.Push("item3");

            Assert.AreEqual("item3", _stack.Pop());
            Assert.AreEqual("item2", _stack.Pop());
            Assert.AreEqual("item1", _stack.Pop());
        }
    }
}
