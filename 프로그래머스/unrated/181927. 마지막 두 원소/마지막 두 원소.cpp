#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer(num_list.size()+1);
    int num = 0;
    if(num_list[num_list.size()-1] > num_list[num_list.size()-2])
        num = num_list[num_list.size() -1] - num_list[num_list.size()-2];
    else
        num = num_list[num_list.size()-1] * 2;

    for(int i = 0; i < answer.size()-1; i++)
    {
        answer[i] = num_list[i];
    }
    answer[num_list.size()] = num;
    return answer;
}