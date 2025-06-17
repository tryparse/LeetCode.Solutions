using Shouldly;

namespace LeetCode.Learning.Tests
{
    public class QueueTests
    {
        [Fact]
        public void WhenEnqueue_ThenCountIncreases()
        {
            var queue = new Queue<int>(10);
            queue.Enqueue(1);

            queue.Count.ShouldBe(1);

            queue.Enqueue(2);

            queue.Count.ShouldBe(2);
        }

        [Fact]
        public void WhenDequeue_ThenCountDecreases()
        {
            var queue = new CustomQueue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);

            queue.Count.ShouldBe(2);

            var first = queue.Dequeue();
            first.ShouldBe(1);
            queue.Count.ShouldBe(1);

            var second = queue.Dequeue();
            second.ShouldBe(2);
            queue.Count.ShouldBe(0);
        }
    }
}
