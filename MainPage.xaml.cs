using System.Diagnostics;

namespace maui_barcode_entry_test;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_Completed(object sender, EventArgs e)
	{
		Entry entry = sender as Entry;
		Trace.WriteLine("Scanned: " + entry.Text);
		entry.Text = "";

	}
}

