namespace MauiResourcesTest;

public partial class MainPage : ContentPage
{
	public static readonly BindableProperty CountProperty = BindableProperty.Create(nameof(Count), typeof(int), typeof(MainPage), defaultValue: 0);

	public int Count
	{ 
		get => (int)GetValue(CountProperty);
		set => SetValue(CountProperty, value);
	}

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Count++;

		if (Count == 1)
			CounterBtn.Text = $"Clicked {Count} time";
		else
			CounterBtn.Text = $"Clicked {Count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

