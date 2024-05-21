namespace Pedra_Papel_Tesoura.Pedra_Papel_Tesoura;

public class Itens : ContentPage
{
	public Itens()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}