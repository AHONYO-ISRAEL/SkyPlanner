namespace SkyPlanner.Pages.BookPages;
using SkyPlanner.Pages.ChoosePages;

public partial class OneWay : ContentPage
{
    private readonly SkyPlannerDatabase database;
    private int a;
    private int c;
    private int i;


    public OneWay(SkyPlannerDatabase database)
    {
        InitializeComponent();
        this.database = database;

    }
    public OneWay(int a, int c, int i)
	{
        InitializeComponent();



        //Navigate to ChoosePassenger page
        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += OnFrameTapped;

       
        iconFrame.GestureRecognizers.Add(tapGestureRecognizer);
        //

        //Retrieve data
        this.a= a;
        this.c= c;
        this.i= i;

        anumber.Text = a.ToString();
        cnumber.Text = c.ToString();
        inumber.Text = i.ToString();
        
    }


    public OneWay() { 
    InitializeComponent();
    } 

    private void OnFrameTapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ChoosePassenger());
    }


    private void SelectDate(object sender, DateChangedEventArgs e)
    {
        DateTime selectedDate = e.NewDate;
    }

    private void Toflight(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SelectPlaces());
    }
}