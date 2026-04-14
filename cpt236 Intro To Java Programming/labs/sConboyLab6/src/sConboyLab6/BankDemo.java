package sConboyLab6;

import javax.swing.*;

public class BankDemo {

	public static void main(String[] args) 
	{
		
		// declare variables
		String accountNumber;
		String accountType;
		String name;
		String email;
		String phoneNumber;
		String riskLevel;
		String cryptoType;
		String userChoice = "";
		
		double balance;
		double deposit;
		double withdraw;
		double interestRate;
		double overdraftLimit;
		double investmentBalance;
		double cryptoBalance;
		
		boolean validChoice;
		boolean complete = false;
		
		JOptionPane input = new JOptionPane();
		
		BankAccount[] account = new BankAccount[1];
		
		
		// ask one time about account creation _______________________________________________________________________________________________
		try
		{
			while (!complete)
			{
				userChoice = input.showInputDialog(null, "Welcome to the bank. "
						+ "\nEnter an account type to begin."
						+ "\n(Savings, Checking, Crypto, Mutual Fund, or Regular)").toLowerCase();
				
				
				// validate userChoice as a type of account
				if (userChoice.equals("savings") || 
						userChoice.equals("checking") || 
						userChoice.equals("crypto") ||
						userChoice.equals("mutual fund") ||
						userChoice.equals("regular"))
				{
					validChoice = true;
				}
				else
				{
					JOptionPane.showMessageDialog(null, "Invalid account type. Try again... Spell that thing right.");
				}
				
				
				
				// switch to create account based on what user inputs
				switch(userChoice)
				{
				case "savings":
					AccountInfo savingsAccount = getInfo();
					interestRate = Double.parseDouble(input.showInputDialog(null, "Enter interest rate."));
					
					SavingsAccount savingsAcc = new SavingsAccount(savingsAccount.accountNumber, savingsAccount.name, 
							savingsAccount.email, savingsAccount.phone, 
							savingsAccount.balance, interestRate);
					account[0] = savingsAcc;
					savingsAcc.AccountInfo();
					complete = true;
					break;
					
				case "crypto":
					AccountInfo cryptoAccount = getInfo();
					cryptoBalance = Double.parseDouble(input.showInputDialog(null, "Enter crypto balance."));
					cryptoType = input.showInputDialog(null, "Enter crypto Type.\nBitcoin, Dogecoin, etc...");
					
					CryptoAccount cryptoAcc = new CryptoAccount(cryptoAccount.accountNumber, cryptoAccount.name, 
							cryptoAccount.email, cryptoAccount.phone, 
							cryptoAccount.balance, cryptoBalance, cryptoType);
					account[0] = cryptoAcc;
					cryptoAcc.AccountInfo();
					complete = true;
					break;
					
				case "checking":
					AccountInfo checkingAccount = getInfo();
					overdraftLimit = Double.parseDouble(input.showInputDialog(null, "Enter overdraft limit."));
					
					CheckingAccount checkingAcc = new CheckingAccount(checkingAccount.accountNumber, checkingAccount.name, 
							checkingAccount.email, checkingAccount.phone, 
							checkingAccount.balance, overdraftLimit);
					account[0] = checkingAcc;
					checkingAcc.AccountInfo();
					complete = true;
					break;
					
				case "mutual fund":
					AccountInfo mutualFund = getInfo();
					investmentBalance = Double.parseDouble(input.showInputDialog(null, "Enter investment balance."));
					riskLevel = input.showInputDialog(null, "Enter risk level.\n(Low, Medium, High)");
					
					MutualFund mutFund = new MutualFund(mutualFund.accountNumber, mutualFund.name, mutualFund.email, 
							mutualFund.phone, mutualFund.balance, investmentBalance, riskLevel);
					account[0] = mutFund;
					mutFund.AccountInfo();
					complete = true;
					break;
				case "regular":
					AccountInfo regular = getInfo();
					
					BankAccount regAcc = new BankAccount(regular.accountNumber, regular.name, regular.email, 
							regular.phone, regular.balance);
					account[0] = regAcc;
					regAcc.AccountInfo();
					complete = true;
				}
			}	
		}
		catch (Exception e)
		{
			input.showMessageDialog(null, e);
		}
		
		
		// now i need to create a menu to do deposits, withdrawls, and display account info. ________________________________________________
		try
		{
			while (!userChoice.equals("q"))
			{
				userChoice = input.showInputDialog(null, account[0].getName() + "                          Balance : " + account[0].getBalance()
						+ "\nWould you like to "
						+ "\n1 - Make Deposit"
						+ "\n2 - Make Withdraw"
						+ "\nQ - Quit App");
				
				switch(userChoice)
				{
				case "1":
					// deposit stuff
					deposit = Double.parseDouble(input.showInputDialog(null, "Enter deposit amount."));
					account[0].deposit(deposit);
					break;
				case "2":
					// withdraw stuff
					withdraw = Double.parseDouble(input.showInputDialog(null, "Enter withdraw amount."));
					account[0].withdraw(withdraw);
					break;
				case "q":
					input.showMessageDialog(null, "Closing App. Thank you.");
					break;
				}
			}			
		}
		catch (Exception e)
		{
			input.showMessageDialog(null, e);
		}
	}

	// method to get all the basic account info so that it can be passed through
	private static AccountInfo getInfo() 
	{
	    JOptionPane input = new JOptionPane();

	    AccountInfo info = new AccountInfo();

	    info.accountNumber = input.showInputDialog("Enter account number:");
	    info.name = input.showInputDialog("Enter name:");
	    info.email = input.showInputDialog("Enter email:");
	    info.balance = Double.parseDouble(input.showInputDialog("Enter initial balance:"));

	    return info;
	}
}