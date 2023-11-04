var maxProfit = function(prices) {
    let max = 0;
        let i = 0;
        let j = prices.length - 1;
        while( i < prices.length) {
            while(j > i) {
                let compare = Math.max((prices[j] - prices[i]), 0);
                max = Math.max(compare, max);
                j --;
            }
            j = prices.length - 1;
            i ++;
        }
        return max;
};