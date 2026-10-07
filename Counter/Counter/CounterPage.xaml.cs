
using Counter.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Counter;

public partial class CounterPage : ContentPage
{
    int counterValue = 0;
    public ObservableCollection<Models.CounterModel> Counters { get; set; } = new();
    public CounterPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
    private void NewCounterButtonClicked(object sender, EventArgs e)
    {
        Counters.Add(new Models.CounterModel()
        {
            CounterName = CounterNameInput.Text
        });
        CounterNameInput.Text = string.Empty;
    }

    private void IncreaseCounterButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        StackLayout wiersz = (StackLayout)button.Parent;
        Label counterLabel = (Label)wiersz.Children[1];
        CounterModel counter = (CounterModel)button.BindingContext;

        counter.CounterValue = counter.CounterValue + 1;
        counterLabel.Text = counter.CounterValue.ToString();
    }

    private void DecreaseCounterButtonClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        StackLayout wiersz = (StackLayout)button.Parent;
        Label counterLabel = (Label)wiersz.Children[1];
        CounterModel counter = (CounterModel)button.BindingContext;

        counter.CounterValue = counter.CounterValue - 1;
        counterLabel.Text = counter.CounterValue.ToString();
    }
}