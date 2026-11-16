namespace ROBRUNRaidCalculator;

public class RaidCalculator
{
    /// <summary>
    /// Calculates the number of decoders required for a raid.
    /// The result is an approximation based on community defense data.
    /// </summary>
    public int CalculateDecoders(BuildingType building, FuseRarity fuses)
    {
        int baseDefense = GetBaseDefense(building);
        int fuseMultiplier = GetFuseMultiplier(fuses);
        return baseDefense * fuseMultiplier;
    }

    /// <summary>
    /// Estimates the profit of a raid for the given building setup.
    /// </summary>
    public ProfitEstimate EstimateProfit(BuildingType building, bool hasGrowhouse, bool hasSafe)
    {
        int decoders = CalculateDecoders(building, FuseRarity.Legendary);
        decimal rentalIncomePerDecoder = GetRentalIncome(building, hasGrowhouse, hasSafe);
        decimal decoderCost = 25000m;
        decimal profitPerDecoder = Math.Max(0m, rentalIncomePerDecoder - decoderCost);
        decimal minProfit = profitPerDecoder * decoders;
        decimal maxProfit = profitPerDecoder * decoders * 2m;

        return new ProfitEstimate
        {
            Min = minProfit,
            Max = maxProfit,
            WorthIt = maxProfit > decoderCost * decoders
        };
    }

    private int GetBaseDefense(BuildingType building)
    {
        switch (building)
        {
            case BuildingType.Trailer:
                return 0;
            case BuildingType.SmallHouse:
                return 15;
            case BuildingType.ConcreteFence:
                return 10;
            case BuildingType.MetalFence:
                return 5;
            case BuildingType.Garage:
                return 4;
            case BuildingType.Warehouse:
                return 10;
            case BuildingType.Mansion:
                return 30;
            default:
                return 0;
        }
    }

    private int GetFuseMultiplier(FuseRarity fuses)
    {
        switch (fuses)
        {
            case FuseRarity.Green:
                return 1;
            case FuseRarity.Purple:
                return 3;
            case FuseRarity.Legendary:
                return 5;
            default:
                return 1;
        }
    }

    private decimal GetRentalIncome(BuildingType building, bool hasGrowhouse, bool hasSafe)
    {
        decimal income = 500m;

        if (hasGrowhouse)
        {
            income = income * 2m;
        }

        if (hasSafe)
        {
            income = income * 1.5m;
        }

        return income;
    }
}
