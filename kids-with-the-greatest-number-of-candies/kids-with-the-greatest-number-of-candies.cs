public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = -1;
        var cnt = candies.Count();
        var arr = new bool[cnt];
        for (var i = 0; i < cnt; i++) {
            if (candies[i] > max)
                max = candies[i];
        }
        for (var i = 0; i < cnt; i++) {
            arr[i] = candies[i] + extraCandies >= max;
        }
        return arr;
    }
}
