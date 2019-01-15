using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public partial class ScoreHistoryPage : ContentPage
	{
        Label label;
        StackLayout list_view, graph_view, current;
        Switch switcher;

        public ScoreHistoryPage ()
		{
            InitializeComponent ();
            var lstView = new ListView();
            lstView.ItemsSource = new List<String>() 
            { 
                "11/02: 7", "11/05: 5", "11/06: 8", "11/12: 7", "11/05: 5", 
                "11/06: 8", "11/12: 7", "11/05: 5", "11/06: 8", "11/12: 7", 
                "11/05: 5", "11/06: 8", "11/12: 7", "11/02: 7", "11/05: 5", 
                "11/06: 8", "11/12: 7", "11/05: 5", "11/06: 8", "11/12: 7", 
                "11/05: 5", "11/06: 8", "11/12: 7", "11/05: 5", "11/06: 8", 
                "11/12: 7" 
            };

            switcher = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            switcher.Toggled += switcher_Toggled;

            label = new Label
            {
                Text = "List",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            list_view = new StackLayout
            {
                Children =
                {
                    new Button
                    {
                        Text = "Back",
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        HorizontalOptions = LayoutOptions.Start
                    },
                    lstView,
                    new Button
                    {
                        Text = "Manually Add Score",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Button
                    {
                        Text = "Log a Fall",
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    label,
                    switcher
                }
            };

            current = list_view;
            this.Content = current;
         }

        void switcher_Toggled(object sender, ToggledEventArgs e)
        { 
            if (e.Value == true)
            {
                label.Text = "Graph";
            }
            else
            {
                label.Text = "List";
            }
        }
    }

}

