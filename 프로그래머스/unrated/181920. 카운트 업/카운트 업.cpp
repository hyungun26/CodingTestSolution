#include <string>
#include <vector>

using namespace std;

vector<int> solution(int start_num, int end_num) {
    vector<int> answer(end_num - start_num + 1);
    for(int i = 0; i < end_num - start_num + 1; i++)
    {
        answer[i] = i+start_num;
    }
    return answer;
}