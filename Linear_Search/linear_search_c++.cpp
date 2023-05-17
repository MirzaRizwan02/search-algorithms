// Linear Search in C++

#include <iostream>
using namespace std;

int linearSearch(int arr[], int size, int target) {
    // Iterate through each element in the array
    for (int i = 0; i < size; i++) {
        // Check if the current element is equal to the target element
        if (arr[i] == target) {
            // Return the index of the target element
            return i;
        }
    }
    // If the target element is not found, return -1
    return -1;
}
