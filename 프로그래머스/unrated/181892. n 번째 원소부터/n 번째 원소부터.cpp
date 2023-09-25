#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list, int n) {
    vector<int> answer(num_list.size() - n + 1);
    for(int i = 0; i < answer.size(); i++)
    {
        answer[i] = num_list[n+i-1];
    }
    return answer;
}