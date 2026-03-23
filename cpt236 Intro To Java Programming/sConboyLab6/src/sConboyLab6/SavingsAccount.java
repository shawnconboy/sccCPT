package sConboyLab6;

import javax.swing.JOptionPane;

public class SavingsAccount extends BankAccount 
{
	
	// properties __________________________________________________________
	
		private double InterestRate;
		
		JOptionPane input = new JOptionPane();
		
		
	// constructors __________________________________________________________
		
		// default
		public SavingsAccount()
		{
			
			InterestRate = 0;
		}
		
		// parameterized
		public SavingsAccount(String acctNum, String name, String email, String phoneNum, double balance, double interestRate)
		{
			super(acctNum, name, email, phoneNum, balance);
			InterestRate = interestRate;
		}
		
	// methods __________________________________________________________
		
		// getters
		
		public double getInterestRate()
		{
			return InterestRate;
		}
		
		// setters

		public void setInterestRate(double interestRate)
		{
			InterestRate = interestRate;
		}
		
		// actual methods
		
		public void AccountInfo()
		{
			
			input.showMessageDialog(null, "\nAccount Number : " + this.getAcctNum() +
					   "\nAccount Holder : " + this.getName()+
					   "\nAccount Type : Savings" +
					   "\nBalance : " + this.getBalance() +
					   "\nInterest Rate : " + InterestRate );
		}

}
