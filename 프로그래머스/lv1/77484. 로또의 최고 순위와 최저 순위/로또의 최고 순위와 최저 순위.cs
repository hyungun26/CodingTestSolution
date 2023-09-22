using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int count = 0;
        int zeroC = 0;
        for(int i = 0; i < lottos.Length; i++)
        {
            for(int j = 0; j < win_nums.Length; j++)
            {
                if(lottos[i] == win_nums[j])
                {
                    count++;
                }
            }
            if(lottos[i] == 0)
            {
                zeroC++;
            }
        }

        int max = count + zeroC;
        int min = count;

        switch(max)
        {
            case 2: answer[0] = 5;
                break;
            case 3: answer[0] = 4;
                break;
            case 4: answer[0] = 3;
                break;
            case 5: answer[0] = 2;
                break;
            case 6: answer[0] = 1;
                break;
            default : answer[0] = 6; 
                break;
        }

        switch(min)
        {
            case 2: answer[1] = 5;
                break;
            case 3: answer[1] = 4;
                break;
            case 4: answer[1] = 3;
                break;
            case 5: answer[1] = 2;
                break;
            case 6: answer[1] = 1;
                break;
            default : answer[1] = 6; 
                break;
        }

        //answer[0] = count + zeroC; //0이 다 맞았을 경우
        //answer[1] = count; // 0이 다 틀렸을 경우


        Console.Write(count);


        return answer;
    }
}
