public class Solution {
    public string FreqAlphabets(string s) {
        s = s.Replace("10#", "j");
        s = s.Replace("11#", "k");
        s = s.Replace("12#", "l");
        s = s.Replace("13#", "m");
        s = s.Replace("14#", "n");
        s = s.Replace("15#", "o");
        s = s.Replace("16#", "p");
        s = s.Replace("17#", "q");
        s = s.Replace("18#", "r");
        s = s.Replace("19#", "s");
        s = s.Replace("20#", "t");
        s = s.Replace("21#", "u");
        s = s.Replace("22#", "v");
        s = s.Replace("23#", "w");
        s = s.Replace("24#", "x");
        s = s.Replace("25#", "y");
        s = s.Replace("26#", "z");
        
        s = s.Replace("1", "a");
        s = s.Replace("2", "b");
        s = s.Replace("3", "c");
        s = s.Replace("4", "d");
        s = s.Replace("5", "e");
        s = s.Replace("6", "f");
        s = s.Replace("7", "g");
        s = s.Replace("8", "h");
        s = s.Replace("9", "i");
 
        return s;
