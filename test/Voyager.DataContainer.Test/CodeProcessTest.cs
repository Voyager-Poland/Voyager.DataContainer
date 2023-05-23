namespace Voyager.DataContainer.Test
{
	public class CodeProcessTest
	{

		string spyText = string.Empty;
		CodeProcess codeProcess;

		[SetUp]
		public void Setup()
		{
			codeProcess = new SpyClass(setContent);
		}

		private void setContent(string contentValue)
		{
			spyText = contentValue;
		}

		[Test]
		public void AddAla()
		{
			codeProcess.AddLine("Ala");
			codeProcess.GetContent();
			Assert.That(spyText, Is.EqualTo("Ala"));
			Assert.Pass();
		}

		[Test]
		public void AddAlaMaKota()
		{
			codeProcess.AddLine("Ala");
			codeProcess.AddLine("Ma");
			codeProcess.AddLine("Kota");
			byte dwa = 2;
			codeProcess.AddLine(dwa);
			codeProcess.AddLine((int)int.MaxValue);
			codeProcess.GetContent();
			Assert.That(spyText, Is.EqualTo("Ala\aMa\aKota\a2\a2147483647"));
			Assert.Pass();
		}


		[Test]
		public void AddDataTime()
		{
			codeProcess.AddLine(new DateTime(2022, 3, 22, 12, 12, 01));
			codeProcess.GetContent();
			Assert.That(spyText, Is.EqualTo("20220322121201"));
			Assert.Pass();
		}
	}
}