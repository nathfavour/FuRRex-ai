namespace FuRRex_AI;

public partial class AboutPage : ContentPage
{
    private Command learnMoreCommand;

    public AboutPage()
    {
        InitializeComponent();

        learnMoreCommand = new Command(this.LearnMore);
    }

    private void LearnMore()
    {
        // Do something when the button is clicked.
    }
}
