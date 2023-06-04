namespace SkyPlanner.Pages;
using SkyPlanner.Pages.BookPages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    async void ToSearch(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Search());
    }


    private bool _rotated = false;

    private async void Action(object sender, EventArgs e)
    {
        ((Button)sender).RotateTo(_rotated? 0: -90);
        

        floatingbtns.Margin = new Thickness(0, 0, _rotated?0:-100, 80);

        floatingbtns.Animate<Thickness>("bookbtn",
            value =>
            {
                int factor = Convert.ToInt32(value * 10);

                var rightMargin =
                !_rotated ?
                (factor * 10) - 100
                : (factor * 10) * -1;
                

                

                return new Thickness(0,0, rightMargin, 80);
            },
            newThickness => floatingbtns.Margin = newThickness, 
            length:100,
            finished:(_, __) => _rotated = !_rotated);
        

        

    }

    int a = 1;
    int c = 0;
    int i= 0;

    private async void ToOneWay(object sender, EventArgs e)
    {
      await  Navigation.PushAsync(new OneWay(a,c,i));
    }

    private async void ToRoundTrip(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RoundTrip());
    }
}