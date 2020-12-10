public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var arr = new int[nums.Count()];
        for (var i = 0; i < nums.Count(); i++) {
            var cnt = 0;
            for (var j = 0; j < nums.Count(); j++) {
                if (i != j && nums[j] < nums[i])
                    cnt++;
            }
            arr[i] = cnt;
        }
        return arr;
    }
}
