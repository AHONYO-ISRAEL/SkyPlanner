namespace SkyPlanner.Pages.BookPages;
using SkyPlanner.Pages.ChoosePages;

public partial class RoundTrip : ContentPage
{
    private int a;
    private int c;
    private int i;
    public RoundTrip(int a, int c, int i)
	{
		InitializeComponent();
        //Navigate to ChoosePassenger page
        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += OnFrameTapped;


        iconFrame.GestureRecognizers.Add(tapGestureRecognizer);
        //

        //Retrieve data
        this.a = a;
        this.c = c;
        this.i = i;

        anumber.Text = a.ToString();
        cnumber.Text = c.ToString();
        inumber.Text = i.ToString();

    }

    public RoundTrip()
    {
        InitializeComponent();
    }

    private void OnFrameTapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ChoosePassenger());
    }

    private void SelectDate(object sender, DateChangedEventArgs e)
    {

    }

    private void Toflight(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SelectPlaces());
    }
}