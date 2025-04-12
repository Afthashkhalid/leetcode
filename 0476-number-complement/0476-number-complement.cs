public class Solution {
    public int FindComplement(int num) {
        string s = Convert.ToString(num, 2);
        s = s.Replace("1","-").Replace("0","1").Replace("-","0");
        return Convert.ToInt32(s,2);
    }
}