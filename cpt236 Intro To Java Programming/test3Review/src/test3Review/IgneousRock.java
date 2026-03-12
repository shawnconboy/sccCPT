package test3Review;

public class IgneousRock extends Rock
{
	
// declare fields
	private String Name = "Igneous";
	private String Description = "\"fire-born\" rocks formed by the cooling and solidification of molten magma or lava, constituting a major part of the Earth's crust.";
	
// constructors
	public IgneousRock(int sampleNum, double weight)
	{
		this.setSampleNum(sampleNum);
		this.setWeight(weight);
		this.setDescription(Description);
	}
	
// methods
	public String toString()
	{
		return "Rock Type : " + Name +
			   "\nNumber of Samples : " + this.getSampleNum() + 
			   "\nRock Weight : " + this.getWeight() + 
			   "\nRock Description : " + Description;
	}
}
