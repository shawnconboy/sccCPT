package sConboyLab7;

import java.awt.FlowLayout;

import javax.swing.*;

public class BankFrame extends JFrame
{
	
	JLabel headerLabel = new JLabel("Bank App");
	
	JLabel accountSelection = new JLabel("Select an account type.");
	
	JCheckBox regularCheckbox = new JCheckBox("Regular");
	JCheckBox checkingCheckbox = new JCheckBox("Checking");
	JCheckBox savingsCheckbox = new JCheckBox("Savings");
	JCheckBox cryptoCheckbox = new JCheckBox("Crypto");
	JCheckBox mutualFundCheckbox = new JCheckBox("Mutual Fund");
	
	public BankFrame()
	{
		super("Bank App");
		setSize(500, 400);
		setLayout(new FlowLayout(FlowLayout.CENTER));
	
		add(headerLabel);
		
		add(accountSelection);
		
		ButtonGroup accountSelector = new ButtonGroup();
		accountSelector.add(regularCheckbox);
		accountSelector.add(checkingCheckbox);
		accountSelector.add(savingsCheckbox);
		accountSelector.add(cryptoCheckbox);
		accountSelector.add(mutualFundCheckbox);
		
		add(regularCheckbox);
		add(checkingCheckbox);
		add(savingsCheckbox);
		add(cryptoCheckbox);
		add(mutualFundCheckbox);
		
		setVisible(true);
	}

}
