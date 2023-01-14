using HamburguesaEM.Models;
namespace HamburguesaEM.Views;

public partial class BurgerListPageEM : ContentPage
{
    public BurgerListPageEM()
    {
        InitializeComponent();
        List<BurgerEM> burger = App.BurgerRepoEM.GetAllBurgers();
        burgerListEM.ItemsSource = burger;
    }
    async void OnItemAddedEM(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageEM));
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        List<BurgerEM> burger = App.BurgerRepoEM.GetAllBurgers();
        burgerListEM.ItemsSource = burger;
    }

}