public class Solution {
    public int Maximum69Number (int num) {
        var s = num.ToString();
        var newString = "";
        var exchanges = 0;
        for (var i = 0; i < s.Count(); i++) {
            if (exchanges == 0 && s[i] == '6') {
                exchanges = 1;
                newString += "9";
            }
            else {
                newString += s[i];
            }
        }
        return Int32.Parse(newString);
    }
}
