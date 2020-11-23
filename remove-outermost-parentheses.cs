public class Solution {
    public string RemoveOuterParentheses(string S) {
        var cnt = 0;
        var newS = "";
        for (var i = 0; i < S.Count(); i++) {
            if (S[i] == '(' && cnt++ != 0) 
                newS += S[i];
                
            if (S[i] == ')' && --cnt != 0) 
                newS += S[i];
        }
        return newS;
    }
}
