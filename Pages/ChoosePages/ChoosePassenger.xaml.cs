namespace SkyPlanner.Pages.ChoosePages;
using SkyPlanner.Pages.BookPages;

public partial class ChoosePassenger : ContentPage
{
	public ChoosePassenger()
	{
		InitializeComponent();
	}

    int i = 0;
    private void Iminus(object sender, EventArgs e)
    {
        while (i > 0)
        {
            i--;
            inumber.Text = i.ToString();
        }

    }

    private void Iplus(object sender, EventArgs e)
    {
        i++;
        inumber.Text = i.ToString();
    }

    int c = 0;
    private void Cminus(object sender, EventArgs e)
    {
        while (c > 0)
        {
            c--;
            cnumber.Text = c.ToString();
        }

    }

    private void Cplus(object sender, EventArgs e)
    {
        c++;
        cnumber.Text = c.ToString();
    }
    int a = 1;
    private void Aminus(object sender, EventArgs e)
    {
        while (a > 0)
        {
            a--;
            anumber.Text = a.ToString();
        }

    }

    private void Aplus(object sender, EventArgs e)
    {
        a++;
        anumber.Text = a.ToString();
    }

    private async void ToBack(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OneWay(a,c,i));
    }
}