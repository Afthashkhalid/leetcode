public class Solution {
    public string[] SortPeople(string[] names, int[] heights) =>
        Enumerable.Range(0, names.Length)
        .Select(i => new { name = names[i], height = heights[i] })
        .OrderByDescending(m => m.height)
        .Select(m => m.name)
        .ToArray();
}