package sConboyLab6;

import javax.swing.JOptionPane;

public class CryptoAccount extends BankAccount 
{
	
	// properties __________________________________________________________
	
		private double CryptoBalance;
		private String CryptoType;
		
		JOptionPane input = new JOptionPane();
		
		
	// constructors __________________________________________________________
		
		// default
		public CryptoAccount()
		{
			
			CryptoBalance = 0;
			CryptoType = "";
		}
		
		// parameterized
		public CryptoAccount(String acctNum, String name, String email, String phoneNum, double balance,double cryptoBalance, String riskLevel)
		{
			super(acctNum, name, email, phoneNum, balance);
			CryptoBalance = cryptoBalance;
			CryptoType = riskLevel;
			
		}
		
	// methods __________________________________________________________
		
		// getters
		
		public double getCryptoBalance()
		{
			return CryptoBalance;
		}
		
		public String getCryptoType()
		{
			return CryptoType;
		}
		
		// setters

		public void setCryptoBalance(double balanceBalance)
		{
			CryptoBalance = balanceBalance;
		}
		
		public void setCryptoType(String cryptoType)
		{
			CryptoType = cryptoType;
		}
		
		// actual methods
		
		public void AccountInfo()
		{
			
			input.showMessageDialog(null, "\nAccount Number : " + this.getAcctNum() +
							   "\nAccount Holder : " + this.getName()+
							   "\nAccount Type : Crypto" +
							   "\nBalance : " + this.getBalance() +
							   "\nCrypto Balance : " + CryptoBalance +
							   "\nCrypto Type : " + CryptoType);
		}
}
