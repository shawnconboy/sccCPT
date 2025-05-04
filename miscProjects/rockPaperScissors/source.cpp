#include <cstdlib>
#include <ctime>
#include <iostream>

using namespace std;

string choiceToString(int choice) {
  if (choice == 1)
    return "Rock";
  if (choice == 2)
    return "Paper";
  if (choice == 3)
    return "Scissors";
  return "Unknown";
}

int main() {
  system("clear");

  const int rock = 1;
  const int paper = 2;
  const int scissors = 3;

  int userChoice = 0;
  int computerChoice = 0;
  int userWins = 0;
  int computerWins = 0;
  int ties = 0;

  srand(time(0));  // seed random generator

  for (int round = 1; round <= 3; round++) {
    cout << "\n--- Round " << round << " ---\n";
    cout << "1 -- Rock\n";
    cout << "2 -- Paper\n";
    cout << "3 -- Scissors\n\n";

    cout << "Rock, Paper, or Scissors? : ";
    cin >> userChoice;

    computerChoice = (rand() % 3) + 1;

    cout << "You chose: " << choiceToString(userChoice) << endl;
    cout << "Computer chose: " << choiceToString(computerChoice) << endl;

    if (userChoice == computerChoice) {
      cout << "Tie Game!\n";
      ties++;
    } else if ((userChoice == rock && computerChoice == scissors) ||
               (userChoice == paper && computerChoice == rock) ||
               (userChoice == scissors && computerChoice == paper)) {
      cout << "You win this round!\n";
      userWins++;
    } else {
      cout << "Computer wins this round!\n";
      computerWins++;
    }
  }

  // Final results
  cout << "\n=== Final Results ===\n";
  cout << "You won: " << userWins << " time(s)\n";
  cout << "Computer won: " << computerWins << " time(s)\n";
  cout << "Ties: " << ties << "\n";

  if (userWins > computerWins) {
    cout << "🎉 You win the game!\n";
  } else if (computerWins > userWins) {
    cout << "💻 Computer wins the game!\n";
  } else {
    cout << "🤝 It's a tie overall!\n";
  }

  return 0;
}
