package chapter14;
import java.awt.*;

import javax.swing.*;

public class JFrame1App {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub

		// thisa looks likea shit
		JFrame.setDefaultLookAndFeelDecorated(false);
		
		// frame is created here
		JFrame aFrame = new JFrame("First Frame");
		aFrame.setSize(500,500);
		aFrame.setVisible(true);
		aFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		// greeting label is created here
		JLabel greeting = new JLabel("Good day.");
		
		// creates font settings named "headlineFont"
		Font headlineFont = new Font("Arial", Font.BOLD, 36);
		
		// assigns the font to greeting
		greeting.setFont(headlineFont);
		
		aFrame.setLayout(new FlowLayout());
		
		// adds greeting to the frame
		aFrame.add(greeting);
		
	}

}
