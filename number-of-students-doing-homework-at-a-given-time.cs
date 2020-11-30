public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        var cnt = 0;
        for (var i = 0; i < startTime.Count(); i++) {
            if (queryTime >= startTime[i] && queryTime <= endTime[i]) {
                cnt++;
            }
        }
        return cnt;
    }
}
