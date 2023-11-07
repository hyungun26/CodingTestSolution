public class Solution {
    public string solution(int n) {
        string answer = "";
        bool check = false;
        if(n % 2 == 1)
            check = true;
        n /= 2;
        for(int i = 0; i < n; i++)
        {
            answer += "수박";
        }
        if(check)
            answer += "수";
        return answer;
    }
}