public class Solution {
    public string solution(string s) {
        string answer = s;
        char[] cArr = answer.ToCharArray();
        System.Array.Sort(cArr);
        System.Array.Reverse(cArr);
        answer = "";
        foreach(var i in cArr)
        {
            answer += i;
        }
        return answer;
    }
}