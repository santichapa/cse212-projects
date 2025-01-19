using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: create a quque with two items, Item1 (pri:1) and Item2 (pri:1)
    // Expected Result: Item2 (pri:1)
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var Item1 = new PriorityItem("Item1", 1);
        var Item2 = new PriorityItem("Item2", 1);

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(Item1.Value, Item1.Priority);
        priorityQueue.Enqueue(Item2.Value, Item2.Priority);

        var lastIndex = priorityQueue.Length-1;
        var queueString = priorityQueue.ToString();
        var lastItem = queueString.Split(", ")[lastIndex].Replace("]", "");

        Assert.AreEqual(lastItem, Item2.ToString());

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: create a queue with three items in this order of enqueue: Item1 (pri:1), Item2 (pri:1), Item3 (pri:1)
    // Expected Result: "Item1 (pri:1), Item2(pri:1), Item3(pri:1)"
    // Defect(s) Found: none 
    public void TestPriorityQueue_2()
    {
        var Item1 = new PriorityItem("Item1", 1);
        var Item2 = new PriorityItem("Item2", 1);
        var Item3 = new PriorityItem("Item3", 1);

        string expectedResult = $"{Item1.ToString()}, {Item2.ToString()}, {Item3.ToString()}";

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(Item1.Value, Item1.Priority);
        priorityQueue.Enqueue(Item2.Value, Item2.Priority);
        priorityQueue.Enqueue(Item3.Value, Item3.Priority);

        var queueString = priorityQueue.ToString().Replace("[", "").Replace("]", "");
        
        Assert.AreEqual(queueString, string.Join(", ", expectedResult));
    
        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: create a queue with four items and different priorities in this order of enqueue: Item1 (pri:1), Item2 (pri:1), Item3 (pri:3), Item4 (pri:4)
    // Expected Result: Item4
    // Defect(s) Found: the dequeue method is not returning the item with the highest priority
    public void TestPriorityQueue_3()
    {
        var Item1 = new PriorityItem("Item1", 3);
        var Item2 = new PriorityItem("Item2", 6);
        var Item3 = new PriorityItem("Item3", 7);
        var Item4 = new PriorityItem("Item4", 8);

        var expectedResult = Item4.Value;
        
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(Item1.Value, Item1.Priority);
        priorityQueue.Enqueue(Item2.Value, Item2.Priority);
        priorityQueue.Enqueue(Item3.Value, Item3.Priority);
        priorityQueue.Enqueue(Item4.Value, Item4.Priority);

        var item = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, item);

    }

    [TestMethod]
    // Scenario: create a queue with two items with the same priority and two with different priorities 
    // in this order of enqueue: Item1 (pri:3), Item2 (pri:6), Item3 (pri:6), Item4 (pri:2)
    // Expected Result: Item2, Item3, Item1, Item4
    // Defect(s) Found: the dequeue does not return the priority items with same priority in the correct order
    public void TestPriorityQueue_4()
    {
        var Item1 = new PriorityItem("Item1", 3);
        var Item2 = new PriorityItem("Item2", 6);
        var Item3 = new PriorityItem("Item3", 6);
        var Item4 = new PriorityItem("Item4", 2);

        var expectedResult = new PriorityItem[] {Item2, Item3, Item1, Item4};
        
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(Item1.Value, Item1.Priority);
        priorityQueue.Enqueue(Item2.Value, Item2.Priority);
        priorityQueue.Enqueue(Item3.Value, Item3.Priority);
        priorityQueue.Enqueue(Item4.Value, Item4.Priority);

        var i = 0;
        while (priorityQueue.Length > 0)
        {
            var currentItem = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, currentItem.ToString());
            i++;
        }

    }
}