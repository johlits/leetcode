public class Solution {
    public int SubtractProductAndSum(int n) {
        var product = 1;
        var sum = 0;
        var s = n.ToString();
        for (var i = 0; i < s.Count(); i++) {
            int j = s[i] - '0';
            product *= j;
            sum += j;
        }
        return product - sum;
    }
}
