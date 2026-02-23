package chapter7Exercises;

import java.util.Scanner;

public class CountWords {

	public static void main(String[] args) 
    {
        Scanner input = new Scanner(System.in);

        System.out.println("Please enter some text:");
        StringBuilder userInput = new StringBuilder(input.nextLine());

        int wordCount = 0;
        boolean previousWasLetter = false;

        for (int i = 0; i < userInput.length(); i++) {

            char current = userInput.charAt(i);

            if (Character.isLetterOrDigit(current)) {

                if (previousWasLetter == false) {
                    wordCount++;
                }

                previousWasLetter = true;

            } else {
                previousWasLetter = false;
            }
        }

        System.out.println("You have a total of " + wordCount + " words.");

        input.close();
    }
}