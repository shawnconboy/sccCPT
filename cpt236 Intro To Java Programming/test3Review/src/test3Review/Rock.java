package test3Review;

public class Rock 
{

// declare fields
	private int SampleNum;
	private String Description;
	private double Weight;

// declare constructors
	public Rock()
	{
		SampleNum = 0;
		Weight = 0.0;
		Description = "Unclassified";
	}
	
	public Rock(int sampleNum, double weight)
	{
		SampleNum = sampleNum;
		Weight = weight;
		Description = "Unclassified";
	}
	
// declare methods
	
	// getters
	public int getSampleNum()
	{
		return SampleNum;
	}
	
	public String getDescription()
	{
		return Description;
	}
	
	public double getWeight()
	{
		return Weight;
	}
	
	// setters
	public void setSampleNum(int sampleNum)
	{
		SampleNum = sampleNum;
	}
	
	public void setDescription(String desc)
	{
		Description = desc;
	}
	
	public void setWeight(double weight)
	{
		Weight = weight;
	}
	
	public String toString()
	{
		return "Number of Samples : " + SampleNum + 
			   "\nRock Weight : " + Weight + 
			   "\nRock Description : " + Description;
	}
}
