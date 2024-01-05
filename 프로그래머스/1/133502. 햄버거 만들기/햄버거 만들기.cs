using System;
using System.Text;

public class Solution {
    public int solution(int[] args) {
        int res = 0;
        StringBuilder sb = new StringBuilder();
        int length = args.Length;
        for (int i = 0; i < length; i++) 
        {
            sb.Append(args[i]);
            if (sb.Length >= 4 && sb.ToString(sb.Length-4,4).Equals("1231")) 
            {
                res++;
                sb.Remove(sb.Length-4,4);
            }
        }
        return res;
    }
}