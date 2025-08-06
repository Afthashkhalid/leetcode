public class Solution {
    public long InterchangeableRectangles(int[][] rectangles) {
return rectangles.GroupBy(x=>x[0]/(double)x[1]).Select(x=>x.Count()).Sum(x=>(long)x*(x-1)/2); 
    }
}