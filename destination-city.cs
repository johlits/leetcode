public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var dic = new Dictionary<string, int>();
        for (var i = 0; i < paths.Count(); i++) {
            var from = paths[i][0];
            var to = paths[i][1];
            if (dic.ContainsKey(from)) {
                dic[from]++;
            }
            else {
                dic[from] = 1;
            }
            if (!dic.ContainsKey(to)) {
                dic[to] = 0;
            }
        }
        
        foreach(KeyValuePair<string, int> entry in dic)
        {
            if (entry.Value == 0) {
                return entry.Key;
            }
        }
        
        return null;
    }
}
