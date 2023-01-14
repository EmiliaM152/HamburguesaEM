using HamburguesaEM.Models;
namespace HamburguesaEM.Views;

public partial class BurgerItemPageEM : ContentPage
{
    BurgerEM Item = new BurgerEM();
    bool _flag;
    public BurgerItemPageEM()
	{
		InitializeComponent();
	}
    private void OnSaveClickedEM(object sender, EventArgs e)
    {
        Item.Name = nameEM.Text;
        Item.Description = descEM.Text;
        Item.WithExtraCheese = _flag;
        App.BurgerRepoEM.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClickedEM(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChangedEM(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private async void DeleteButtonClickedEM(object sender, EventArgs e)
    {
        if (BindingContext is Models.BurgerEM hambEM)
        {
            // Delete the file.
            if (File.Exists(hambEM.Name))
                File.Delete(hambEM.Name);
        }
    
        await Shell.Current.GoToAsync("..");
    }
}