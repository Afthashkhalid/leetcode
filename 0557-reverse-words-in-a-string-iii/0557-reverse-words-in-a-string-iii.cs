public class Solution {
    public string ReverseWords(string s) {
        return String.Join(" ",s.Split(" ").Select(e=>new string(e.Reverse().ToArray())));

    }
}