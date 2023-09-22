#include <string>
#include <vector>

using namespace std;

int solution(string num_str) {
    int answer = 0;
    for(int i = 0; i < num_str.size(); i++)
    {
        int a = (int)num_str[i];
        answer += a % 48;
    }
    return answer;
}