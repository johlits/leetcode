public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        var m = mat.Count(); // 3
        var n = mat[0].Count(); // 4
        List<int>[,] a = new List<int>[m, n];
        for (var y = 0; y < m; y++) { // 3
            for (var x = 0; x < n; x++) { // 4
                a[y,x] = new List<int>();
                if (y == 0) {
                    a[y,x].Add(mat[y][x]);
                }
                else if (x == 0) {
                    a[y,x].Add(mat[y][x]);
                }
                else {
                    var xx = x;
                    var yy = y;
                    if (y > x) {
                        yy -= xx;
                        xx = 0;
                    }
                    else if (x > y) {
                        xx -= yy;
                        yy = 0;
                    }
                    else {
                        xx = 0;
                        yy = 0;
                    }
                    a[yy,xx].Add(mat[y][x]);
                }
