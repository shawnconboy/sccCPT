package chapter4Exercises;

public class DogTriathalonParticipant 
{
	
	// variable declarations
	private final int 	NUM_EVENTS;
	private static int 	totalCumulativeScore;
	
	private String 	name;
	private int 	obedienceScore;
	private int 	conformationScore;
	private int 	agilityScore;
	private int 	total;
	private double 	average;
	
	public DogTriathalonParticipant(String name, int numEvents, int score1, int score2, int score3)
	{
		this.name 			= name;
		NUM_EVENTS 			= numEvents;
		obedienceScore 		= score1;
		conformationScore 	= score2;
		agilityScore 		= score3;
		
		total = obedienceScore + conformationScore + agilityScore;
		average = (double) total / NUM_EVENTS;
		totalCumulativeScore = totalCumulativeScore + total;
	}
	
	public void display()
	{
		System.out.println(name + " paricipated in " + NUM_EVENTS + " events and has an average score of " + average);
		System.out.println(name + " has a total score of " + total + " bringing the total cumulative score to " + totalCumulativeScore);
	}
}
