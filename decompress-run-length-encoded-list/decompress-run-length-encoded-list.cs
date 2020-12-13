public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        var l = new List<int>();;
        for (var i = 0; i < nums.Count(); i+=2) {
            var freq = nums[i];
            var val = nums[i+1];
            for (var j = 0; j < freq; j++) {
                l.Add(val);
            }
        }
        return l.ToArray();
    }
}
