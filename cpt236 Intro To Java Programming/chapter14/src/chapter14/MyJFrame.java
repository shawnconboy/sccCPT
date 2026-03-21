package chapter14;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class MyJFrame extends JFrame implements ActionListener 
{
	// Buttons
	JButton submitButton = new JButton("Submit");
	JButton resetButton = new JButton("Reset");
	
	public MyJFrame()
	{
	// JFrame
		JFrame window = new JFrame("Frames and Things Demo");
		
		// sets container to middle of screen
		window.setLocationRelativeTo(null);
		
		// size of container
		window.setSize(300,300);
		
	// Text Fields
		JTextField nameTxt = new JTextField(20);
		JTextField ageTxt = new JTextField(20);
		
		
	// flow layout
		FlowLayout layout = new FlowLayout();
		
	// JLabel
		JLabel nameLabel = new JLabel("Please enter your name : ");
		JLabel ageLabel = new JLabel("Please enter your age : ");
		
	// add them to the frame
		window.setLayout(layout);
		window.add(nameLabel);
		window.add(nameTxt);
		window.add(ageLabel);
		window.add(ageTxt);
		window.add(submitButton);
		window.add(resetButton);
		
		// registers submit button for listening
		submitButton.addActionListener(this);
		resetButton.addActionListener(this);
		
		
		// make that bittie visible
		window.setVisible(true);
	}

	@Override
	public void actionPerformed(ActionEvent e) 
	{
		if(submitButton.isEnabled())
		{
			submitButton.setText("Submitted!");
			submitButton.setEnabled(false);			
		}
		
		if(e.getSource() == resetButton)
		{
			System.out.println(e);
			System.out.println("Reset button clicked.");
			submitButton.setEnabled(true);
			submitButton.setText("Submit");
		}
	}
}
