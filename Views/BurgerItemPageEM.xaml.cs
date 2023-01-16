using HamburguesaEM.Data;
using HamburguesaEM.Models;

namespace HamburguesaEM.Views;

[QueryProperty(nameof(EMaux), "Aux")]
public partial class BurgerItemPageEM : ContentPage
{
    BurgerEM Item = new BurgerEM();
    BurgerEM Aux = new BurgerEM();
    bool _flag;

    public BurgerItemPageEM()
	{
		InitializeComponent();
       
    }
    public BurgerEM EMaux
    {
        get => Aux;
        set=>Aux = value;
    }

    private async void OnSaveClickedEM(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Name = nameEM.Text;
        Item.Description = descEM.Text;
        Item.WithExtraCheese = _flag ;

        if (string.IsNullOrEmpty(Item.Name) || string.IsNullOrEmpty(Item.Description))
        {
            return;
        }
        App.BurgerRepoEM.AddNewBurger(Item);
        await Shell.Current.GoToAsync("..");
    }

    private async void CancelClickedEM(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    private void CheckedChangedEM(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
      
    private async void OnDeleteClickedEM(object sender, EventArgs e)
    {
	    Item = Aux;
	    App.BurgerRepoEM.DeleteBurger(Item);
	    await Shell.Current.GoToAsync("..");
    
    }
}
