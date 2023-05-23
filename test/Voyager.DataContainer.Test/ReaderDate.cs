namespace Voyager.DataContainer.Test
{
	internal class ReaderDate : CommonEncoder
	{
		CodeReader codeReader;

		[SetUp]
		public void SetUp()
		{
			codeReader = new CodeReader(this.GetBytes("20220322121201"));
		}

		[Test]
		public void Test()
		{
			DateTime data = codeReader.GetValueDateTime();

			Assert.That(data, Is.EqualTo(new DateTime(2022, 3, 22, 12, 12, 01)));

		}
	}
}