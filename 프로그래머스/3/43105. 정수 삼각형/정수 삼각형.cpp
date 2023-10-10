#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<vector<int>> triangle) {
    int answer = 0;
    int size = triangle.size();
    
    for(int i = size - 1; i > 0; i--)
    {
        for(int j = i; j > 0; j--)
        {
            triangle[i-1][j-1] += max(triangle[i][j],triangle[i][j-1]);
        }
    }
    answer = triangle[0][0];
    return answer;
}