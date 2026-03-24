package paulasPortrait;
import java.awt.FlowLayout;

import javax.swing.*;

// Create an application for Paula’s Portraits, a photography studio. 
// The application allows users to compute the price of a photography session. 
// Paula’s base price is $40 for an in-studio photo session with one person. 
// The in-studio fee is $75 for a session with two or more subjects, and $95 for a session with a pet. 
// A $90 fee is added to take photos on location instead of in the studio. 
// Include a set of mutually exclusive check boxes to select the portrait subject and another set for the session location. 
// Include labels as appropriate to explain the application’s functionality. Save the file as JPhotoFrame.java.


// cost of session
// 		$40 base session
//		$75 in studio, 2 or more people
//		$95 pet session
//		$90 extra if not onsite
// gui =>
// checkboxes for subject and location
// 

public class JPhotoFrame extends JFrame
{

	JLabel nameLabel = new JLabel("Name: ");
	JTextField nameText = new JTextField(20);
	
	JLabel costLabel = new JLabel("Cost : $");
	JButton calculate = new JButton("Calculate");
	JCheckBox singleCheckbox = new JCheckBox("Single");
	JCheckBox multipleCheckbox = new JCheckBox("Multiple");
	JCheckBox petCheckbox = new JCheckBox("Pet");
	
	JCheckBox onSiteCheckbox = new JCheckBox("Onsite Location");
	JCheckBox offSiteCheckbox = new JCheckBox("Offsite Location");
	
	public JPhotoFrame()
	{
		super("Paula's Portrait Application");
		setSize(300,400);
		
		setLayout(new FlowLayout(FlowLayout.CENTER));
		
		ButtonGroup personBox = new ButtonGroup();
		ButtonGroup locationBox = new ButtonGroup();
		
		
		
		add(nameLabel);
		add(nameText);
		
		
		personBox.add(singleCheckbox);
		personBox.add(multipleCheckbox);
		personBox.add(petCheckbox);

		locationBox.add(onSiteCheckbox);
		locationBox.add(offSiteCheckbox);
		
		add(singleCheckbox);
		add(multipleCheckbox);
		add(petCheckbox);
		add(onSiteCheckbox);
		add(offSiteCheckbox);
		
		add(calculate);
		add(costLabel);
		
		setVisible(true);
		
		
		
		
	}
}
