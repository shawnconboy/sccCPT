package sConboyLab7;

import javax.swing.JOptionPane;

public class MutualFund extends BankAccount 
{
	
	// properties __________________________________________________________
	
		private double InvestmentBalance;
		private String RiskLevel;
		
		JOptionPane input = new JOptionPane();
		
		
	// constructors __________________________________________________________
		
		// default
		public MutualFund()
		{
			
			InvestmentBalance = 0;
			RiskLevel = "";
		}
		
		// parameterized
		public MutualFund(String acctNum, String name, String email, String phoneNum, double balance, double investmentBalance, String riskLevel)
		{
			super(acctNum, name, email, phoneNum, balance);
			InvestmentBalance = investmentBalance;
			RiskLevel = riskLevel;
			
		}
		
	// methods __________________________________________________________
		
		// getters
		
		public double getInvestmentBalance()
		{
			return InvestmentBalance;
		}
		
		public String getRiskLevel()
		{
			return RiskLevel;
		}
		
		// setters

		public void setInvestmentBalance(double investmentBalance)
		{
			InvestmentBalance = investmentBalance;
		}
		
		public void setRiskLevel(String riskLevel)
		{
			RiskLevel = riskLevel;
		}
		
		// actual methods
		
		public void AccountInfo()
		{
			
			input.showMessageDialog(null, "\nAccount Number : " + this.getAcctNum() +
							   "\nAccount Holder : " + this.getName()+
							   "\nAccount Type : Mutual Fund" +
							   "\nBalance : " + this.getBalance() +
							   "\nInvestment Balance : " + InvestmentBalance +
							   "\nRisk Level : " + RiskLevel);
		}
}
