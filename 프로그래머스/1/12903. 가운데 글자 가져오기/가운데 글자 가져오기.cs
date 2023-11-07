public class Solution {
    public string solution(string s) {
        string answer = "";
        int num = s.Length;
        int a = 1;
        if(num % 2 == 1)
        {
            num = s.Length/2;
        }
        else
        {
            num = s.Length/2-1;
            a = 2;
        }
            
        answer = s.Substring(num, a);
        return answer;
    }
}