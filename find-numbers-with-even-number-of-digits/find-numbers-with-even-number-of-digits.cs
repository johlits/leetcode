public class Solution {
    public int FindNumbers(int[] nums) {
        var cnt = 0;
        for (var i = 0; i < nums.Count(); i++) {
            if (nums[i].ToString().Count() % 2 == 0)
                cnt++;
        }
        return cnt;
    }
}
