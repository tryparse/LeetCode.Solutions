using System;

namespace LeetCode.Solutions.Solutions.Easy.BestTimeToBuyAndSellStock
{
    public class BestTimeToBuyAndSellStockSolution
    {
        public int MaxProfit(int[] prices)
        {
            // 7,1,5,3,6,4
            // 5
            if (prices == null
                || prices.Length <= 1)
            {
                return 0;
            }

            var maxProfit = 0;
            var minPrice = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                var price = prices[i];
                minPrice = Math.Min(price, minPrice);

                var profit = price - minPrice;
                maxProfit = Math.Max(profit, maxProfit);
            }

            return maxProfit;
        }
    }
}
