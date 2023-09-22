#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    for(int i = 0; i < num_list.size(); i++)
    {
        answer = num_list[i];
        if(answer < 0)
        {
            answer = i;
            break;
        }
        answer = -1;
    }
    return answer;
}