using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        DateTime monthFirst = new DateTime(2016, a, b);
        int nFirstDay = Int32.Parse(monthFirst.DayOfWeek.ToString("d"));
        
        switch(nFirstDay)
        {
            case 0: answer = "SUN";
                break;
            case 1: answer = "MON";
                break;
            case 2: answer = "TUE";
                break;
            case 3: answer = "WED";
                break;
            case 4: answer = "THU";
                break;
            case 5: answer = "FRI";
                break;
            case 6: answer = "SAT";
                break;
        }
        
        return answer;
    }
}