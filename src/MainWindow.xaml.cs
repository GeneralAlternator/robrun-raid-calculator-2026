using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ROBRUNRaidCalculator;

namespace ROBRUNRaidCalculator;

public partial class MainWindow : Window
{
    private readonly RaidCalculator _raidCalculator = new RaidCalculator();

    private readonly LaundryTimer _laundryTimer = new LaundryTimer();

    public MainWindow()
    {
        InitializeComponent();
        BuildingComboBox.ItemsSource = GetBuildingTypes();
        FuseComboBox.ItemsSource = GetFuseRarities();
        _laundryTimer.TimerCompleted += LaundryTimer_TimerCompleted;
    }

    private List<BuildingType> GetBuildingTypes()
    {
        List<BuildingType> buildingTypes = new List<BuildingType>();
        buildingTypes.Add(BuildingType.Trailer);
        buildingTypes.Add(BuildingType.SmallHouse);
        buildingTypes.Add(BuildingType.ConcreteFence);
        buildingTypes.Add(BuildingType.MetalFence);
        buildingTypes.Add(BuildingType.Garage);
        buildingTypes.Add(BuildingType.Warehouse);
        buildingTypes.Add(BuildingType.Mansion);
        return buildingTypes;
    }

    private List<FuseRarity> GetFuseRarities()
    {
        List<FuseRarity> fuseRarities = new List<FuseRarity>();
        fuseRarities.Add(FuseRarity.Green);
        fuseRarities.Add(FuseRarity.Purple);
        fuseRarities.Add(FuseRarity.Legendary);
        return fuseRarities;
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
        BuildingType building = (BuildingType)BuildingComboBox.SelectedItem;
        FuseRarity fuses = (FuseRarity)FuseComboBox.SelectedItem;

        int decoders = _raidCalculator.CalculateDecoders(building, fuses);
        RaidResultTextBlock.Text = "Decoders required: " + decoders;

        ProfitEstimate estimate = _raidCalculator.EstimateProfit(building, false, false);
        ProfitResultTextBlock.Text = "Profit estimate: min " + estimate.Min + ", max " + estimate.Max + ", worth it: " + estimate.WorthIt;
    }

    private void StartTimerButton_Click(object sender, RoutedEventArgs e)
    {
        if (decimal.TryParse(DirtyCashTextBox.Text, out decimal amount))
        {
            _laundryTimer.StartTimer(amount);
            TimerStatusTextBlock.Text = "Timer started for " + amount + ".";
        }
        else
        {
            TimerStatusTextBlock.Text = "Enter a valid amount.";
        }
    }

    private void StopTimerButton_Click(object sender, RoutedEventArgs e)
    {
        _laundryTimer.StopTimer();
        TimerStatusTextBlock.Text = "Timer stopped.";
    }

    private void LaundryTimer_TimerCompleted(object sender, EventArgs e)
    {
        TimerStatusTextBlock.Text = "Laundering cycle completed.";
    }
}
