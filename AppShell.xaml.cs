namespace HamburguesaEM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.BurgerItemPageEM), typeof(Views.BurgerItemPageEM));
        Routing.RegisterRoute(nameof(Views.BurgerListPageEM), typeof(Views.BurgerListPageEM));
    }
}
