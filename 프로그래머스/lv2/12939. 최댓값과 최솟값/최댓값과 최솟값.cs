using System;
using System.Linq;


public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] arr = s.Split(" ");//문자열을 문자열배열로 변환 
        //ex) {1, 2, 3, 4}
        //지금 문제가 문자열에서 최소값을 찾으려니까 절대값으로 찾아버림 -를 무시함
        
        int[] qwe = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
        {
            int c = Int32.Parse(arr[i]);
            qwe[i] = c;
            Console.Write(qwe[i]);
        }
        
        int a = qwe.Max();
        int b = qwe.Min();
        
        answer = b.ToString() + " " + a.ToString();
        
        
        
        
        return answer;
    }
}