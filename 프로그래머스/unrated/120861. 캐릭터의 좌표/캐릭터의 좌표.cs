using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        for(int i = 0; i < keyinput.Length; i++)
        {
            switch(keyinput[i])
            {
                case "right": answer[0]++;
                    if(answer[0] > board[0] / 2)
                        answer[0] = board[0]/2;
                    break;
                case "left": answer[0]--;
                    if(answer[0] < -(board[0] / 2))
                        answer[0] = -(board[0]/2);
                    break;
                case "up": answer[1]++;
                    if(answer[1] > board[1] / 2)
                        answer[1] = board[1]/2;
                    break;
                case "down": answer[1]--;
                    if(answer[1] < -(board[1] / 2))
                        answer[1] = -(board[1]/2);
                    break;
            }
        }
        return answer;
    }
}