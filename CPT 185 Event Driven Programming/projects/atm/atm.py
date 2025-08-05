import time, sys, os

def header():
    print("==== Welcome to Mini ATM ====\n")

def menu():
    print("1. View Balance")
    print("2. Make Deposit")
    print("3. Make Witdrawl")
    print("4. Exit ATM")

def clearScreen():
    os.system("cls")

clearScreen()

header()
response = input("Begin Program? (Y/N) : ")

balance = 1000
depositAmount = 0
withdrawAmount = 0

while response == 'y':
    clearScreen()
    header()
    menu()

    userChoice = int(input("\nPlease choose a selection : "))

    while userChoice != 4:

        if userChoice == 1:
            print(f"Current balance : {balance:.2f}")
        elif userChoice == 2:
            depositAmount = int(input("How much would you like to deposit? : "))
            balance += depositAmount
        elif userChoice == 3:
            withdrawAmount = int(input("How much would you like to withdraw? : "))
            balance -= withdrawAmount
        elif userChoice == 4:
            print("Exiting ATM.")
        else:
            print("Invalid Choice.")

    response = input("\nWould you like to run again? (Y/N) : ").lower()

print("Program ended. Thank You.")