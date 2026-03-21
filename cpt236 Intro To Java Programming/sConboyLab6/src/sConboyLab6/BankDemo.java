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
		String userChoice;
		
		
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
		
		while (!complete)
		{
			userChoice = input.showInputDialog(null, "Welcome to the bank. "
												   + "\nEnter an account type to begin."
												   + "\n(Savings, Checking, Crypto, Mutual Fund, or Regular)").toLowerCase();
			
			if (userChoice.equals("savings") || 
				userChoice.equals("checking") || 
				userChoice.equals("crypto") ||
				userChoice.equals("mutual fund") ||
				userChoice.equals("user"))
			{
				validChoice = true;
			}
			else
			{
				JOptionPane.showMessageDialog(null, "Invalid account type. Try again... Spell that thing right.");
			}
			
			switch(userChoice)
			{
			case "savings":
				AccountInfo savingsAccount = getInfo();
				interestRate = Double.parseDouble(input.showInputDialog(null, "Enter interest rate."));
				
				SavingsAccount savingsAcc = new SavingsAccount(savingsAccount.accountNumber, savingsAccount.name, savingsAccount.email, savingsAccount.phone, savingsAccount.balance, interestRate);
				savingsAcc.AccountInfo();
				complete = true;
				break;
				
			case "crypto":
				AccountInfo cryptoAccount = getInfo();
				cryptoBalance = Double.parseDouble(input.showInputDialog(null, "Enter crypto balance."));
				cryptoType = input.showInputDialog(null, "Enter crypto Type.\nBitcoin, Dogecoin, etc...");
				
				CryptoAccount cryptoAcc = new CryptoAccount(cryptoAccount.accountNumber, cryptoAccount.name, cryptoAccount.email, cryptoAccount.phone, cryptoAccount.balance, cryptoBalance, cryptoType);
				cryptoAcc.AccountInfo();
				complete = true;
				break;
				
			case "checking":
				AccountInfo checkingAccount = getInfo();
				overdraftLimit = Double.parseDouble(input.showInputDialog(null, "Enter overdraft limit."));
				
				CheckingAccount checkingAcc = new CheckingAccount(checkingAccount.accountNumber, checkingAccount.name, checkingAccount.email, checkingAccount.phone, checkingAccount.balance, overdraftLimit);
				checkingAcc.AccountInfo();
				complete = true;
				break;
				
			case "mutual fund":
				AccountInfo mutualFund = getInfo();
				investmentBalance = Double.parseDouble(input.showInputDialog(null, "Enter investment balance."));
				riskLevel = input.showInputDialog(null, "Enter risk level.\n(Low, Medium, High)");
				
				MutualFund mutFund = new MutualFund(mutualFund.accountNumber, mutualFund.name, mutualFund.email, mutualFund.phone, mutualFund.balance, investmentBalance, riskLevel);
				mutFund.AccountInfo();
				complete = true;
				break;

			}
		}		
	}

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