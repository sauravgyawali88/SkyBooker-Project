using SkyBooker_Project.Models;
using SkyBooker_Project.PageModels;

namespace SkyBooker_Project.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}