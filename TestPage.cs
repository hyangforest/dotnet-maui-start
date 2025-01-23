namespace dotnet_maui;

public class TestPage : ContentPage
{
	int count = 0;

	Label counterLabel;

	public TestPage()
	{
		var myScrollVeiw = new ScrollView();
		var myStackLayout = new VerticalStackLayout();
		myScrollVeiw.Content = myStackLayout;

		counterLabel = new Label
		{
			Text = "현재 카운터 : 0",
            FontSize = 18,
			FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center
        };
		myStackLayout.Children.Add(counterLabel);

		var myButton = new Button
		{
			Text = "버튼 클릭",
			HorizontalOptions = LayoutOptions.Center
        };
		myStackLayout.Children.Add(myButton);

		myButton.Clicked += OnCounterClicked;
		this.Content = myScrollVeiw;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        counterLabel.Text = $"현재 카운터 : {count}";

		SemanticScreenReader.Announce(counterLabel.Text);
    }
}