#include <iostream>

int main()
{
    int rows = 20; // Number of rows

    int i = rows; // Initialize outer loop variable
    while (i > 0)
    {              // Outer loop (controls rows)
        int j = 0; // Inner loop counter

        do
        {
            std::cout << "*"; // Print asterisk
            j++;              // Increment inner loop counter
        } while (j < i); // Condition for printing stars

        std::cout << std::endl; // Move to the next line
        i--;                    // Decrease row count
    }

    return 0;
}
