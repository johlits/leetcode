public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var jewels = new HashSet<char>();
        for (var i = 0; i < J.Count(); i++) {
            jewels.Add(J[i]);
        }
        var result = 0;
        for (var i = 0; i < S.Count(); i++) {
            if (jewels.Contains(S[i])) {
                result++;
            }
        }
        return result;
    }
}
