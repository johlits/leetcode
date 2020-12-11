public class Solution {
    public string RestoreString(string s, int[] indices) {
        var newString = new StringBuilder(s);
        for (var i = 0; i < indices.Count(); i++) {
            newString[indices[i]] = s[i];
        }
        return newString.ToString();
    }
}
