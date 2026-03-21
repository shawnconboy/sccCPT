package sConboyLab6;

public class CheckingAccount extends BankAccount 
{
	
	// properties __________________________________________________________
	
		private double OverdraftLimit;
		
		
	// constructors __________________________________________________________
		
		// default
		public CheckingAccount()
		{
			
			OverdraftLimit = 0;
		}
		
		// parameterized
		public CheckingAccount(String acctNum, String name, String email, String phoneNum, double balance, double overdraftLimit)
		{
			super(acctNum, name, email, phoneNum, balance);
			OverdraftLimit = overdraftLimit;
		}
		
	// methods __________________________________________________________
		
		// getters
		
		public double getOverdraftLimit()
		{
			return OverdraftLimit;
		}
		
		// setters

		public void setOverdraftLimit(double overdraftLimit)
		{
			OverdraftLimit = overdraftLimit;
		}
		
		// actual methods
		
		public void AccountInfo()
		{
			System.out.println("\nAccount Number : " + this.getAcctNum() +
							   "\nAccount Holder : " + this.getName()+
							   "\nAccount Type : Checking" +
							   "\nBalance : " + this.getBalance() +
							   "\nInterest Rate : " + OverdraftLimit);
		}

}
