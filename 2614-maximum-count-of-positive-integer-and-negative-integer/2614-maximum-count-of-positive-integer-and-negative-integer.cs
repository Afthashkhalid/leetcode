public class Solution {
    public int MaximumCount(int[] nums) {
        int negative = nums.Count(i => i < 0);
        int positive = nums.Count(i => i > 0);
        return Math.Max(negative, positive);
    }
}