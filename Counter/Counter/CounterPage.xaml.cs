
using Counter.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Counter;

public partial class CounterPage : ContentPage
{
    int counterValue = 0;
    ObservableCollection<Models.CounterModel> Counters { get; set; } = new();
    public CounterPage()
    {
        InitializeComponent();
    }

    private void CounterButtonPlusClicked(object sender, EventArgs e)
    {
        counterValue++;
        CounterLabel.Text = counterValue.ToString();
    }

    private void CounterButtonMinusClicked(object sender, EventArgs e)
    {
        counterValue--;
        CounterLabel.Text = counterValue.ToString();
    }


    private void NewCounterButtonClicked(object sender, EventArgs e)
    {
        Counters.Add(new Models.CounterModel()
        {
            CounterName = CounterNameInput.Text
        });
    }
}