namespace Voyager.DataContainer.Test
{
	class SpyClass : CodeProcess
	{
		public SpyClass(Action<string> setContent)
		{
			SetContent = setContent;
		}

		public Action<string> SetContent { get; }

		protected override byte[] GetBytes(string text)
		{
			SetContent(text);
			return new Byte[] { };
		}
	}
}