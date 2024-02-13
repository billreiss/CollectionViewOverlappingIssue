using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewOverlappingIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        var dbSource = new ObservableCollection<string>();
        for (int i = 0; i < 40; i++)
        {
            dbSource.Add("Welcome to dot net Multi" + i);
        }
        cv.ItemsSource = dbSource;
    }

    private void populate_Clicked(object sender, EventArgs e)
    {
        headLine.Text = "dot net bot in a race car number 8";
        subHeadLine.Text = "Welcome to dot net Multi platform App";
    }
}


