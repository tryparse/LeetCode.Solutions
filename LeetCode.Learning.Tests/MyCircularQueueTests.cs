using Shouldly;

namespace LeetCode.Learning.Tests
{
    public class MyCircularQueueTests
    {
        [Fact]
        public void ExampleTestCase_1()
        {
            var queue = new MyCircularQueue(3);

            queue.EnQueue(1).ShouldBeTrue();
            queue.EnQueue(2).ShouldBeTrue();
            queue.EnQueue(3).ShouldBeTrue();
            queue.EnQueue(4).ShouldBeFalse();
            queue.Rear().ShouldBe(3);
            queue.IsFull().ShouldBeTrue();
            queue.DeQueue().ShouldBeTrue();
            queue.EnQueue(4).ShouldBeTrue();
            queue.Rear().ShouldBe(4);
        }


        /*
         * ["MyCircularQueue","enQueue","Rear","Front","deQueue","Front","deQueue","Front","enQueue","enQueue","enQueue","enQueue"]
         * [[3],              [2],      [],     [],     [],       [],     [],       [],     [4],      [2],      [2],      [3]]
         */
        [Fact]
        public void ExampleTestCase_2()
        {
            var q = new MyCircularQueue(3);

            q.EnQueue(2).ShouldBeTrue();
            q.Rear().ShouldBe(2);
            q.Front().ShouldBe(2);
            q.DeQueue().ShouldBeTrue();
            q.Front().ShouldBe(-1);
            q.DeQueue().ShouldBeFalse();
            q.Front().ShouldBe(-1);
            q.EnQueue(4).ShouldBeTrue();
            q.EnQueue(2).ShouldBeTrue();
            q.EnQueue(2).ShouldBeTrue();
            q.EnQueue(3).ShouldBeFalse();
        }

        /*
         * ["MyCircularQueue","enQueue","enQueue","deQueue","enQueue","deQueue","enQueue","deQueue","enQueue","deQueue", "Front"]
         * [[2],              [1],      [2],      [],       [3],      [],       [3],      [],       [3],      [],        []]
         */
        [Fact]
        public void ExampleTestCase_3()
        {
            var q = new MyCircularQueue(2);

            q.EnQueue(1).ShouldBeTrue();
            q.EnQueue(2).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.EnQueue(3).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.EnQueue(3).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.EnQueue(3).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.Front().ShouldBe(3);
        }

        /*
         * ["MyCircularQueue","enQueue","deQueue","enQueue","enQueue","deQueue","isFull","isFull","Front","deQueue","enQueue","Front","enQueue","enQueue","Rear","Rear","deQueue","enQueue","enQueue","Rear","Rear","Front","Rear","Rear","deQueue","enQueue","Rear","deQueue","Rear","Rear","Front","Front","enQueue","enQueue","Front","enQueue","enQueue","enQueue","Front","isEmpty","enQueue","Rear","enQueue","Front","enQueue","enQueue","Front","enQueue","deQueue","deQueue","enQueue","deQueue","Front","enQueue","Rear","isEmpty","Front","enQueue","Front","deQueue","enQueue","enQueue","deQueue","deQueue","Front","Front","deQueue","isEmpty","enQueue","Rear","Front","enQueue","isEmpty","Front","Front","enQueue","enQueue","enQueue","Rear","Front","Front","enQueue","isEmpty","deQueue","enQueue","enQueue","Rear","deQueue","Rear","Front","enQueue","deQueue","Rear","Front","Rear","deQueue","Rear","Rear","enQueue","enQueue","Rear","enQueue"]
           [[81],             [69],     [],       [92],     [12],     [],       [],      [],      [],     [],       [28],     [],     [13],[45],[],[],[],[24],[27],[],[],[],[],[],[],[88],[],[],[],[],[],[],[53],[39],[],[28],[66],[17],[],[],[47],[],[87],[],[92],[94],[],[59],[],[],[99],[],[],[84],[],[],[],[52],[],[],[86],[30],[],[],[],[],[],[],[45],[],[],[83],[],[],[],[22],[77],[23],[],[],[],[14],[],[],[90],[57],[],[],[],[],[34],[],[],[],[],[],[],[],[49],[59],[],[71]]
         */

        [Fact]
        public void ExampleTestCase_4()
        {
            var q = new MyCircularQueue(81);

            q.EnQueue(69).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.EnQueue(92).ShouldBeTrue();
            q.EnQueue(12).ShouldBeTrue();
            q.DeQueue().ShouldBeTrue();
            q.IsFull().ShouldBeFalse();
            q.IsFull().ShouldBeFalse();
            q.Front().ShouldBe(12);
        }
    }
}
