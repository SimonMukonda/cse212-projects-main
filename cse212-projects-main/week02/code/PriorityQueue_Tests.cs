using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;





[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities and dequeue all.
    // Expected Result: Highest priority first, then next, then lowest.
    // Defect(s) Found: Initially, Dequeue did not correctly select highest priority.
    public void TestPriorityQueue_DifferentPriorities()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with same priority, check FIFO order.
    // Expected Result: First enqueued item with same priority dequeued first.
    // Defect(s) Found: Initially, same-priority items were not handled FIFO.
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 5);
        pq.Enqueue("Second", 5);
        pq.Enqueue("Third", 5);

        Assert.AreEqual("First", pq.Dequeue());
        Assert.AreEqual("Second", pq.Dequeue());
        Assert.AreEqual("Third", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: Exception type/message incorrect before fix.
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception: {e.GetType()} {e.Message}");
        }
    }

    [TestMethod]
    // Scenario: Mix of priorities and FIFO check.
    // Expected Result: Highest priority dequeued first, then FIFO among equals.
    // Defect(s) Found: Needed to ensure correct ordering when mixing priorities.
    public void TestPriorityQueue_Mixed()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 10);
        pq.Enqueue("C", 10);
        pq.Enqueue("D", 5);

        Assert.AreEqual("B", pq.Dequeue()); // highest priority first
        Assert.AreEqual("C", pq.Dequeue()); // same priority, FIFO
        Assert.AreEqual("D", pq.Dequeue()); // next highest
        Assert.AreEqual("A", pq.Dequeue()); // lowest
    }
}
