namespace ConsoleExampleTest
{
	using NUnit.Framework;
	using ConsoleExample;

	[TestFixture]
	public class ClientTest
	{
		[SetUp]
		protected void SetUp()
		{
		}

		[Test]
		public void HellorWorld()
		{
			Client client = new Client();
			Assert.AreEqual("hello world", client.HelloWorld());
		}
	}
}
