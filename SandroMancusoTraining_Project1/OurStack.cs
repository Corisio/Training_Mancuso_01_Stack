using System;

namespace SandroMancusoTraining_Project1
{
    public class OurStack
    {
        private object lastPushedObject;

        public object Pop()
        {
            if (lastPushedObject == null)
                throw new Exception();
            return lastPushedObject;
        }

        public void Push(object item)
        {
            lastPushedObject = item;
        }
    }
}
