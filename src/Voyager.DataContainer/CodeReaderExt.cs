using System;

namespace Voyager.DataContainer
{
	public static class CodeReaderExt
	{
		public static int GetValueInt32(this CodeReader reader) => int.Parse(reader.GetValue());
		public static Int16 GetValueInt16(this CodeReader reader) => Int16.Parse(reader.GetValue());
		public static byte GetValueByte(this CodeReader reader) => byte.Parse(reader.GetValue());
		public static DateTime GetValueDateTime(this CodeReader reader) => DateTime.ParseExact(reader.GetValue(), "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture);
	}

}