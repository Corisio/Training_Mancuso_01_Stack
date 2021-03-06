# E.1 – TDD lifecycle & naming 
  
## Objective
- Introduce naming convention
- Create production code from test
- Start from assertion
- Tip for deciding the first test to write: The simplest possible.
  
## Problem description: Stack
  
Implement a Stack class with the following public methods:
  
+ void push(Object object)
+ Object pop()
  
Stack should throw an exception if popped when empty.
55 minutes ago


## Sandro's solution

```java
package com.codurance.craftingcode.exercise_01_stack;
 
import org.junit.Before;
import org.junit.Test;
 
import java.util.EmptyStackException;
 
import static org.hamcrest.core.Is.is;
import static org.junit.Assert.assertThat;
 
public class StackShould {
                           
    private static final Object OBJECT_1 = "Some Object";
    private static final Object OBJECT_2 = "Another object";
    private Stack stack;
 
    @Before
    public void initialise() {
        stack = new Stack();
    }
 
    @Test(expected = EmptyStackException.class) public void
    throw_exception_if_popped_when_empty() {
        stack = new Stack();
 
        stack.pop();
    }
 
    @Test public void
    pop_the_last_object_pushed() {
        stack.push(OBJECT_1);
 
        assertThat(stack.pop(), is(OBJECT_1));
    }
 
    @Test public void
    pop_objects_in_the_reverse_order_they_were_pushed() {
        stack.push(OBJECT_1);
        stack.push(OBJECT_2);
 
        assertThat(stack.pop(), is(OBJECT_2));
        assertThat(stack.pop(), is(OBJECT_1));
    }
     
}
 
 
package com.codurance.craftingcode.exercise_01_stack;
 
import java.util.ArrayList;
import java.util.EmptyStackException;
import java.util.List;
 
public class Stack {
    private List<object> objects = new ArrayList<>();
 
    public Object pop() {
        if (objects.isEmpty()) {
            throw new EmptyStackException();
        }
        return objects.remove(objects.size() - 1);
    }
 
    public void push(Object object) {
        this.objects.add(object);
    }
}
```
