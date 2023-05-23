using System.Text;

namespace Voyager.DataContainer
{
	public abstract class CommonEncoder
	{
		Encoding encoder = new UTF8Encoding(true, true);
		protected virtual byte[] GetBytes(string text) => encoder.GetBytes(text);
		protected virtual string GetString(byte[] bytes) => encoder.GetString(bytes);
	}

}