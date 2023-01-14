using HamburguesaEM.Data;

namespace HamburguesaEM;

public partial class App : Application
{
    public static BurgerDatabaseEM BurgerRepoEM { get; private set; }

    public App(BurgerDatabaseEM repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepoEM = repo;
    }
}
