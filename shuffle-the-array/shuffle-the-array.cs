public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var cnt = nums.Count();
        var arr = new int[cnt];
        var j = 0;
        for (var i = 0; i < cnt; i+=2) {
            arr[i] = nums[j++];
        }
        j = 0;
        for (var i = 1; i < cnt; i+=2) {
            arr[i] = nums[n + j++];
        }
        return arr;
    }
}
