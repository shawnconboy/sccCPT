package sConboyLab7;

import javax.swing.JOptionPane;

public class BankAccount 
{
	
// properties __________________________________________________________
	
	private String AccountNumber;
	private String AccountType;
	private String Name;
	private String Email;
	private String PhoneNumber;
	private double Balance;
	
	JOptionPane input = new JOptionPane();
	
	
// constructors __________________________________________________________
	
	// default
	public BankAccount()
	{
		AccountNumber = "";
		AccountType = "";
		Name = "";
		Email = "";
		PhoneNumber = "";
		Balance = 0;
	}
	
	// parameterized
	public BankAccount(String acctNum, String name, String email, String phoneNum, double balance)
	{
		AccountNumber = acctNum;
		Name = name;
		Email = email;
		PhoneNumber = phoneNum;
		Balance = balance;
		AccountType = "";
	}
	
// methods __________________________________________________________
	
	// getters
	
	public String getAcctNum()
	{
		return AccountNumber;
	}
	
	public String getName()
	{
		return Name;
	}
	
	public String getEmail()
	{
		return Email;
	}
	
	public String getPhoneNum()
	{
		return PhoneNumber;
	}
	
	public double getBalance()
	{
		return Balance;
	}
	
	// setters

	public void setAcctNum(String acctNum)
	{
		AccountNumber = acctNum;
	}
	
	public void setName(String name)
	{
		Name = name;
	}
	
	public void setEmail(String email)
	{
		Email = email;
	}
	
	public void setPhoneNum(String phoneNum)
	{
		PhoneNumber = phoneNum;
	}
	
	public void setBalance(double balance) 
	{
		Balance = balance;
	}
	
	// actual methods
	
	public void deposit(double depositAmount)
	{
		
		if (depositAmount < 1)
		{
			input.showMessageDialog(null, "Sorry, you need to deposit at least $1.");
		}
		else 
		{
			Balance += depositAmount;
		}
	}
	
	public void withdraw(double withdrawlAmount)
	{
		double balance = this.getBalance();
		
		if (withdrawlAmount > balance)
		{
			input.showMessageDialog(null, "Sorry. Your withdraw amount is greater than your balance.");
		}
		else 
		{
			Balance -= withdrawlAmount;
		}
	}
	
	public void AccountInfo()
	{	
		
		input.showMessageDialog(null, "\nAccount Number : " + AccountNumber +
				   "\nAccount Holder : " + Name +
				   "\nAccount Type : User" +
				   "\nBalance : " + Balance);
	}
}
