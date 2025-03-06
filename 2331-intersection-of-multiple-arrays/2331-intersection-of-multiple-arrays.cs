public class Solution {
    public IList<int> Intersection(int[][] nums) {
         return nums.Skip(1)
            .Aggregate(nums[0].AsEnumerable(), (s, v) => s.Intersect(v))
            .OrderBy(x => x)
            .ToList();
        }
    }
