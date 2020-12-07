public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var dic = new Dictionary<int, int>();
        var goodPairs = 0;
        for (var i = 0; i < nums.Count(); i++) {
            if (dic.ContainsKey(nums[i])) {
                goodPairs += dic[nums[i]]++;
            }
            else {
                dic[nums[i]] = 1;
            }
        }
        return goodPairs;
    }
}
