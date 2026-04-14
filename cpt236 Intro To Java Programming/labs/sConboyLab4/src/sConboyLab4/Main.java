package sConboyLab4;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) 
    {
    // variable declarations ____________________________________________________________________
        StringBuilder sb = new StringBuilder();
        Scanner input = new Scanner(System.in);
        StringBuilder userChoice = new StringBuilder();

   // Main loop starts ___________________________________________________________________________
        
        while (!userChoice.toString().equals("9")) 
        {

            System.out.println("Text Processor Application");
            System.out.println("Buffer : \"" + sb + "\"");

            System.out.println("\n1 - Append Text\n"
                    +          "2 - Remove Specified Characters\n"
                    +          "2.5 - Replace Specified Characters\n"
                    +          "3 - Display Current Text\n"
                    +          "4 - Save Current Text To History\n"
                    +          "5 - Display History\n"
                    +          "6 - Reverse Text\n"
                    +          "7 - Convert To Upper\n"
                    +          "8 - Convert To Lower\n"
                    +          "9 - Quit Program");

            System.out.print("\nWhat would you like to do? >> ");

            userChoice.setLength(0);
            userChoice.append(input.nextLine());

            // append text
            if (userChoice.toString().equals("1")) 
            {
                System.out.print("What would you like to append? >> ");
                String textToAdd = input.nextLine();

                sb.append(textToAdd);
                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // remove specified characters
            else if (userChoice.toString().equals("2"))
            {
                int indexToRemove;

                System.out.print("What index would you like to remove? >> ");
                indexToRemove = input.nextInt();
                input.nextLine();

                sb.deleteCharAt(indexToRemove);

                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // replace specified characters
            else if (userChoice.toString().equals("2.5"))
            {
            	System.out.print("What character would you like to replace? >> ");
                String targetInput = input.nextLine();

                System.out.print("What character should it become? >> ");
                String replInput = input.nextLine();

                char targetChar = targetInput.charAt(0);
                char newChar = replInput.charAt(0);

                int count = 0;

                for (int i = 0; i < sb.length(); i++)
                {
                    if (sb.charAt(i) == targetChar)
                    {
                        sb.setCharAt(i, newChar);
                        count++;
                    }
                }

                System.out.println("Replaced " + count + " character(s).");
                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // display current text
            else if (userChoice.toString().equals("3")) 
            {
                System.out.println("Current buffer : \"" + sb + "\"");
            }

            // reverse text
            else if (userChoice.toString().equals("6"))
            {
                sb.reverse();
                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // convert to upper
            else if (userChoice.toString().equals("7"))
            {
                String upper = sb.toString().toUpperCase();
                sb.setLength(0);
                sb.append(upper);

                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // convert to lower
            else if (userChoice.toString().equals("8"))
            {
                String lower = sb.toString().toLowerCase();
                sb.setLength(0);
                sb.append(lower);

                System.out.println("Updated buffer : \"" + sb + "\"");
            }

            // quit
            else if (userChoice.toString().equals("9")) 
            {
                System.out.println("Goodbye!");
                break;
            }

            else 
            {
                System.out.println("Stop the cap.");
            }

            System.out.println("\n\n");
        }

        input.close();
    }
}