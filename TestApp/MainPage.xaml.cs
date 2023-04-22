namespace TestApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void TestButton_Clicked(object sender, EventArgs e)
    {
        TestFrame.IsVisible = true;
        TestButton.IsVisible = false;

    }

    public void HideFrameButton_Clicked(object sender, EventArgs e)
    {
        TestFrame.IsVisible = false;
        TestButton.IsVisible = true;
    }
}