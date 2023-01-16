using HamburguesaEM.Data;
using HamburguesaEM.Models;
using System.Linq;

namespace HamburguesaEM.Views;
public partial class BurgerListPageEM : ContentPage
{
    BurgerEM selected;
    public BurgerListPageEM()
    {
        InitializeComponent();
       // List<BurgerEM> burger = App.BurgerRepoEM.GetAllBurgers();
        burgerListEM.ItemsSource = UpdateList();
        //burgerListEM.ItemSelected += OnBurgerSelected;
        //Content = burgerListEM;
    }
    private async void OnItemAddedEM(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Burger");
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        //List<BurgerEM> burger = App.BurgerRepoEM.GetAllBurgers();
        burgerListEM.ItemsSource = App.BurgerRepoEM.GetAllBurgers();
        //burgerListEM.ItemTapped += OnBurgerSelected;

    }

    private async void EMselected(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as BurgerEM;
        await Navigation.PushAsync(new BurgerItemPageEM
        {
            EMaux = selected,
            BindingContext = selected,
        });
    }

    private static List<BurgerEM> UpdateList()
    {
        List<BurgerEM> burger = App.BurgerRepoEM.GetAllBurgers();
        return burger;
    }


}




