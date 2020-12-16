public class Solution {
    public int XorOperation(int n, int start) {
        var ret = 0;
        for (var i = 0; i < n; i++) {
            ret = ret ^ (start + i * 2);
        }
        return ret;
    }
}
