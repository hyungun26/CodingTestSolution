#include <string>
#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer(num_list.size() - 5);
    sort(num_list.begin(), num_list.end());

    for(int i = 0; i < 5; i++)
    {
        num_list.erase(num_list.begin());
    }
        
    for(int i = 0; i < num_list.size(); i++)
    {
        answer[i] = num_list[i];
    }
    return answer;
}