using System;

namespace SandroMancusoTraining_Project1
{
    public class OurStack
    {
        private object lastPushedObject;

        public object Pop()
        {
            return lastPushedObject;
        }

        public void Push(object item)
        {
            lastPushedObject = item;
        }
    }
}
