using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class ScoreHistoryCS : ContentPage
	{
		public ScoreHistoryCS ()
		{
			Title = "Score History";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "Score history data goes here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
