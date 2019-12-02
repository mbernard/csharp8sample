using System;

using Samples.Patterns.Vehicles;

namespace Samples.Patterns
{
    internal class TollCalculatorV2 : ITollCalculator
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
            return vehicle switch
            {
                Car { Passengers: 0 } => 2.00m + 0.50m,
                Car { Passengers: 1 } => 2.0m,
                Car { Passengers: 2 } => 2.0m - 0.50m,
                Car _ => 2.00m - 1.0m,

                Taxi { Fares: 0 } => 3.50m + 1.00m,
                Taxi { Fares: 1 } => 3.50m,
                Taxi { Fares: 2 } => 3.50m - 0.50m,
                Taxi _ => 3.50m - 1.00m,

                Bus b => 5.00m,
                DeliveryTruck t => 10.00m,
                { } => throw new ArgumentException("Not a known vehicle type", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
        }
    }
}