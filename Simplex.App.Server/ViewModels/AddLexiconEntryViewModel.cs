using System;

namespace Simplex.App.Server.ViewModels;

public class AddLexiconEntryViewModel
{
	public string Word { get; set; }
	public string Definition { get; set; }

	public AddLexiconEntryViewModel()
	{
		Word = string.Empty;
		Definition = string.Empty;
	}
}