namespace ROBRUNRaidCalculator;

/// <summary>
/// Building types supported by the raid planner.
/// </summary>
public enum BuildingType
{
    Trailer,
    SmallHouse,
    ConcreteFence,
    MetalFence,
    Garage,
    Warehouse,
    Mansion
}

/// <summary>
/// Fuse rarities that affect the raid decoder calculation.
/// </summary>
public enum FuseRarity
{
    Green,
    Purple,
    Legendary
}

/// <summary>
/// Profit estimate for a raid build.
/// </summary>
public class ProfitEstimate
{
    public decimal Min { get; set; }

    public decimal Max { get; set; }

    public bool WorthIt { get; set; }
}
