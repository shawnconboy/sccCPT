package chapter7Exercises;

import java.util.Scanner;

public class ThreeLetterAcronym {

    public static void main(String[] args) 
    {
        Scanner input = new Scanner(System.in);

        System.out.print("Enter a three word phrase to receive its acronym >> ");
        String userInput = input.nextLine();

        // Split the words by space
        String[] words = userInput.split(" ");

        // Create StringBuilder for acronym
        StringBuilder acronym = new StringBuilder();

        // Take first letter of each word
        for (int i = 0; i < words.length; i++)
        {
            acronym.append(words[i].charAt(0));
        }

        // Convert to uppercase
        System.out.println("Acronym: " + acronym.toString().toUpperCase());

        input.close();
    }
}