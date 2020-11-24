public class Solution {
    public int OddCells(int n, int m, int[][] indices) {
        var arr = new int[n, m];
        for (var i = 0; i < indices.Count(); i++) {
            var ri = indices[i][0];
            var ci = indices[i][1];
            for (var j = 0; j < n; j++) {
                arr[j, ci] += 1;
            }
            for (var j = 0; j < m; j++) {
                arr[ri, j] += 1;
            }
        }
        var cnt = 0;
        for (var i = 0; i < n; i++) {
            for (var j = 0; j < m; j++) {
                if (arr[i, j] % 2 != 0) {
                    cnt++;
                }
            }
        }
        return cnt;
    }
}
