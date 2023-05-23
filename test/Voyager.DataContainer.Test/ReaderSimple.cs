namespace Voyager.DataContainer.Test
{
	internal class ReaderSimple : CommonEncoder
	{
		CodeReader codeReader;

		[SetUp]
		public void SetUp()
		{
			codeReader = new CodeReader(this.GetBytes("Ala\aMa\aKota\a2\a2147483647"));
		}

		[Test]
		public void Test()
		{
			string ala = codeReader.GetValue();
			string ma = codeReader.GetValue();
			string kota = codeReader.GetValue();
			byte dwa = codeReader.GetValueByte();
			int duzo = codeReader.GetValueInt32();

			Assert.That(ala, Is.EqualTo("Ala"));
			Assert.That(ma, Is.EqualTo("Ma"));
			Assert.That(kota, Is.EqualTo("Kota"));
			Assert.That(dwa, Is.EqualTo(2));
			Assert.That(duzo, Is.EqualTo(int.MaxValue));
		}
	}
}