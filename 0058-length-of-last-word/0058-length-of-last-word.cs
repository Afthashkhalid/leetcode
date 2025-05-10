public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string arraylength = s.Split(" ").Last();
        return arraylength.Length;
    }
}