public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;
        int result = 0;
        for(int i = 1; i <= x/i; i++){
            result = i;
        }
        return result;
    }
}