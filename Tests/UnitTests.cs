namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

	[TestMethod]
	public void Sub_Valid_Patino()
	{
		Assert.AreEqual(8, Program.Subtract("10", "2"));
		Assert.AreEqual(1, Program.Subtract("3", "2"));
		Assert.AreEqual(-2, Program.Subtract("5", "7"));
	}

	[TestMethod]
	public void Sub_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "i"));
	}

	[TestMethod]
	public void Sub_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
	}

	[TestMethod]
	public void Mult_Valid_Patino()
	{
		Assert.AreEqual(20, Program.Multiply("10", "2"));
		Assert.AreEqual(35, Program.Multiply("5", "7")); // should fail
	}

	[TestMethod]
	public void Mult_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "i"));
	}

	[TestMethod]
	public void Mult_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
	}

	[TestMethod]
	public void Div_Valid_Patino()
	{
		Assert.AreEqual(5, Program.Divide("10", "2"));
		Assert.AreEqual(10, Program.Divide("70", "7")); 
	}

	[TestMethod]
	public void Div_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "i"));
	}

	[TestMethod]
	public void Div_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
	}

	[TestMethod]
	public void Pow_Valid_Patino()
	{
		Assert.AreEqual(100, Program.Power("10", "2"));
		Assert.AreEqual(1024, Program.Power("2", "1")); // should fail
	}

	[TestMethod]
	public void Pow_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "i"));
	}

	[TestMethod]
	public void Pow_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
	}

}
