//Binary Search in C# (C Sharp)

using System;

public class BinarySearch {
    public static int Search(int[] arr, int target) {
        // Set the lower bound and upper bound
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high) {
            // Calculate the middle index
            int mid = low + (high - low) / 2;

            if (arr[mid] == target) {
                // Return the index if the target is found
                return mid;
            } else if (arr[mid] < target) {
                // Update the lower bound if the target is in the right half
                low = mid + 1;
            } else {
                // Update the upper bound if the target is in the left half
                high = mid - 1;
            }
        }

        // Return -1 if the target is not found
        return -1;
    }
}

