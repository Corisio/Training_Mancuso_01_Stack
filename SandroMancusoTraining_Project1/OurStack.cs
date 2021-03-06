﻿using System.Collections.Generic;
using System.Linq;

namespace SandroMancusoTraining_Project1
{
    public class OurStack
    {
        private readonly IList<object> _pushedObjects;

        public OurStack()
        {
            _pushedObjects = new List<object>();
        }

        public object Pop()
        {
            GuardAgainstEmptyStack();
            return GetLastPushedObject();
        }

        public void Push(object item)
        {
            _pushedObjects.Add(item);
        }

        private void GuardAgainstEmptyStack()
        {
            if (_pushedObjects.Count == 0)
                throw new EmptyStackException();
        }

        private object GetLastPushedObject()
        {
            var lastPushedObject = _pushedObjects.Last();
            _pushedObjects.RemoveAt(_pushedObjects.Count - 1);
            return lastPushedObject;
        }
    }
}
