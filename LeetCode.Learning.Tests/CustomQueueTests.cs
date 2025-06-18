using Shouldly;

namespace LeetCode.Learning.Tests
{
    public class CustomQueueTests
    {
        [Fact]
        public void WhenEnqueue_ThenCountIncreases()
        {
            var queue = new CustomQueue<int>(1, true);

            bool enqueueSuccessfull;
             
            enqueueSuccessfull = queue.Enqueue(1);
            enqueueSuccessfull.ShouldBeTrue();
            queue.Count.ShouldBe(1);
        }

        [Fact]
        public void WhenFixedCapacityAndQueueIsFull_ThenEnqueueReturnFalse()
        {
            var fixedCapacityQueue = new CustomQueue<int>(1, true);

            bool enqueueSuccessfull;

            enqueueSuccessfull = fixedCapacityQueue.Enqueue(1);
            enqueueSuccessfull.ShouldBeTrue();
            fixedCapacityQueue.Count.ShouldBe(1);

            enqueueSuccessfull = fixedCapacityQueue.Enqueue(2);
            enqueueSuccessfull.ShouldBeFalse();
            fixedCapacityQueue.Count.ShouldBe(1);
        }

        [Fact]
        public void WhenDequeue_ThenCountDecreases()
        {
            var queue = new CustomQueue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Count.ShouldBe(2);

            bool dequeueSuccessfull;

            dequeueSuccessfull = queue.Dequeue(out var result);
            dequeueSuccessfull.ShouldBeTrue();
            result.ShouldBe(1);
            queue.Count.ShouldBe(1);

            dequeueSuccessfull = queue.Dequeue(out var result1);
            dequeueSuccessfull.ShouldBeTrue();
            result1.ShouldBe(2);
            queue.Count.ShouldBe(0);
        }

        [Fact]
        public void Debug()
        {
            var queue = new CustomQueue<int>(3, true);

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue(out int result);

            bool enqueueSuccessfull;

            enqueueSuccessfull = queue.Enqueue(4);
            enqueueSuccessfull.ShouldBeTrue();
        }
    }
}
