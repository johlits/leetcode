public class Solution {
    public int MaxProduct(int[] nums) {
        var hi = -1;
        var hin = -1;
        var hifi = -1;
        var hifin = -1;
        for (var i = 0; i < nums.Count(); i++) {
            if (nums[i] > hi) {
                hifi = hi;
                hi = nums[i];
                hifin = hin;
                hin = i;
            }
            else if (nums[i] > hifi) {
                hifi = nums[i];
                hifin = i;
            }
        }
        return (nums[hin]-1)*(nums[hifin]-1);
    }
}
