public class Solution {
    public string TruncateSentence(string s, int k)
    => string.Join(' ', s.Split().Take(k));
}