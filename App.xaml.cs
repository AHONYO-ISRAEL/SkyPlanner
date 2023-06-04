using SkyPlanner.Data;

namespace SkyPlanner;


public partial class App : Application
{

	private static UserFlightRepository UserFlightRepository { get; set; }
	private App(UserFlightRepository userFlightRepository)
	{
		InitializeComponent();

		//MainPage = new AppShell();

		UserFlightRepository = userFlightRepository;
	}
}
