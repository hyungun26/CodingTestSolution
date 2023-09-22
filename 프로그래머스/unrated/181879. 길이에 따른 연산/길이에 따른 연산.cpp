#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
        int num = num_list.size();
        answer = num > 10 ? 0 : 1;
        for(int i = 0; i < num; i++)
        {
            if(num > 10)
                answer += num_list[i];
            else
                answer *= num_list[i];
        }
    return answer;
}