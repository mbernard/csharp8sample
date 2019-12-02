using System;

using Samples.Patterns.Vehicles;

namespace Samples.Patterns
{
    internal class TollCalculatorV5 : ITollCalculator
    {
        public decimal CalculateToll(object vehicle)
        {
            // Price per vehicle type
            // ============
            // Car -> 2$
            // Taxi -> 3.50$
            // Bus -> 5$
            // Truck -> 10$
            //
            // Price considering occupancy
            // ===========
            // Car and taxi
            //   No passengers -> +0.50 $
            //   2 passengers -> -0.50 $
            //   3 or more passengers -> -1$
            // Bus
            //   Less than 50% full -> +2$
            //   More than 90% full -> -1$
            //
            // Price considering weight
            // ===========
            // > 5000 lbs -> +5$
            // < 3000 lbs -> -2$
            return vehicle switch
            {
                Car c => c.Passengers switch
                {
                    0 => 2.00m + 0.5m,
                    1 => 2.0m,
                    2 => 2.0m - 0.5m,
                    _ => 2.00m - 1.0m
                },

                Taxi t => t.Fares switch
                {
                    0 => 3.50m + 1.00m,
                    1 => 3.50m,
                    2 => 3.50m - 0.50m,
                    _ => 3.50m - 1.00m
                },

                Bus b when (double)b.Riders / (double)b.Capacity < 0.50 => 5.00m + 2.00m,
                Bus b when (double)b.Riders / (double)b.Capacity > 0.90 => 5.00m - 1.00m,
                Bus b => 5.00m,

                DeliveryTruck t when t.GrossWeightClass > 5000 => 10.00m + 5.00m,
                DeliveryTruck t when t.GrossWeightClass < 3000 => 10.00m - 2.00m,
                DeliveryTruck t => 10.00m,

                { } => throw new ArgumentException("Not a known vehicle type", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
        }
    }
}