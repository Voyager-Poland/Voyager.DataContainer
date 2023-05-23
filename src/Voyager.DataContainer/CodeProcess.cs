using System.Text;

namespace Voyager.DataContainer
{

	public class CodeProcess : CommonEncoder
	{
		internal const char splitChar = '\x07';
		private readonly StringBuilder sb = new StringBuilder();
		public void AddLine(string line)
		{
			if (sb.Length > 0)
				sb.Append(splitChar);
			sb.Append(line);
		}
		public byte[] GetContent() => GetBytes(sb.ToString());
	}

}