using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] cArr = s.ToCharArray();
        bool check = true;
        for(int i = 0; i < cArr.Length; i++)
        {
            if(cArr[i] == ' ')
            {
                answer += cArr[i];
                check = true;
                continue;
            }
            if(check)
            {
                answer += cArr[i].ToString().ToUpper();
                check = false;
            }
            else
            {
                answer += cArr[i].ToString().ToLower();
                check = true;
            }
        }
        return answer;
    }
}