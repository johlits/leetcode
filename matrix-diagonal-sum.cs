public class Solution {
    public int DiagonalSum(int[][] mat) {
        var s = 0;
        var w = mat.Count();
        var t = w - 1;
        var sum = 0;
        for (var i = 0; i < w; i++) {
            for (var j = 0; j < w; j++) {
                if (j == s || j == t) {
                    sum += mat[i][j];
                }
            }
            s++;
            t--;
        }
        return sum;
    }
}
