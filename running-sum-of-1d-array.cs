public class Solution {
    public int[] RunningSum(int[] nums) {
        var cnt = nums.Count();
        var arr = new int[cnt];
        var running = 0;
        for (var i = 0; i < cnt; i++) {
            running += nums[i];
            arr[i] = running;
        }
        return arr;
    }
}
