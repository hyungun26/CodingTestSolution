using System;


public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        int video_lenN = Convert(video_len);
        int posN = Convert(pos);
        int op_startN = Convert(op_start);
        int op_endN = Convert(op_end);
        for(int i = 0; i < commands.GetLength(0); i++)
        {
            switch(commands[i])  
            {
                case "next": 
                    if(op_startN <= posN && posN <= op_endN)
                        posN = op_endN;
                    posN += 10;
                    if(op_startN <= posN && posN <= op_endN)
                        posN = op_endN;
                    if(posN > video_lenN)
                        posN = video_lenN;
                    
                    break;
                case "prev":
                    if(op_startN <= posN && posN <= op_endN)
                        posN = op_endN;
                    posN -= 10;
                    if(op_startN <= posN && posN <= op_endN)
                        posN = op_endN;
                    else if(posN < 0)
                        posN = 0;
                    break;
            }
        }
        return TimeString(posN);
    }
    
    int Convert(string str)
    {
        int Prev = int.Parse(str.Substring(0,2)) * 60;
        int Next = int.Parse(str.Substring(3,2));
        return Prev + Next;
    }
    
    string TimeString(int Pos)
    {
        int minutes = Pos / 60;
        int seconds = Pos % 60;
        return $"{minutes:D2}:{seconds:D2}";
    }
}