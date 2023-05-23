using System;

namespace Voyager.DataContainer
{
	public static class CodeProcessExt
	{
		public static void AddLine(this CodeProcess codeProcess, Int32 liczba) => codeProcess.AddLine(liczba.ToString());
		public static void AddLine(this CodeProcess codeProcess, Int16 liczba) => codeProcess.AddLine(liczba.ToString());
		public static void AddLine(this CodeProcess codeProcess, Byte liczba) => codeProcess.AddLine(liczba.ToString());
		public static void AddLine(this CodeProcess codeProcess, DateTime data) => codeProcess.AddLine(data.ToString("yyyyMMddHHmmss"));
	}

}