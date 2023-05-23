using System;

namespace Voyager.DataContainer
{
	public class CodeReader : CommonEncoder
	{
		readonly private string[] stringList;
		int readIndex = 0;
		public CodeReader(byte[] bytes)
		{
			String tekst = this.GetString(bytes);
			stringList = tekst.Split(CodeProcess.splitChar);
		}
		public string GetValue() => stringList[readIndex++];

		public int Lenght => stringList.Length;

	}

}