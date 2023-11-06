using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] iArr = {1,2,3,4,5,6,7,8,9};
        answer = iArr.Except(numbers).Sum(); //(List, Array, Dictionary)간의 요소중에서 컬렉션에 중복으로 포함되는 요소를 제외하고 유일한 요소를 찾을때 사용한다 즉 예시 1번을 보면 1~9까지 숫자중 5와 9가 없다. iArr배열에 임시로 1~9까지 요소를 넣고 Except함수를 사용하면 numbers 배열와 비교를 했을때 없는 요소만 따로 찾을 수 있다.
            
        return answer;
    }
}