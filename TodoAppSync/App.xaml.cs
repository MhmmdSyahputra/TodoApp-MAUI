using TodoAppSync.Views.LoginPage;

namespace TodoAppSync;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new LoginPage();
	}
}
