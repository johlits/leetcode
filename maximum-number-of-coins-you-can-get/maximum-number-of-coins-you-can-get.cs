public class Solution {
    public int MaxCoins(int[] piles) {
        var list = new List<int>();
        for(var i = 0; i < piles.Count(); i++) {
            list.Add(piles[i]);
        }
        list.Sort();
        var sum = 0;
        while (list.Count() > 0) {
            list.RemoveAt(0);
            list.RemoveAt(list.Count() - 1);
            sum += list[list.Count() - 1];
            list.RemoveAt(list.Count() - 1);
        }
        return sum;
    }
}
