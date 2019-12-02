using System;

using Samples.Patterns.Vehicles;

namespace Samples.Patterns
{
    internal class TollCalculatorV1 : ITollCalculator
    {
        public decimal CalculateToll(object vehicle)
        {
            // Price per vehicle type
            // ==========
            // Car -> 2$
            // Taxi -> 3.50$
            // Bus -> 5$
            // Truck -> 10$
            return vehicle switch
            {
                Car c => 2.00m,
                Taxi t => 3.50m,
                Bus b => 5.00m,
                DeliveryTruck t => 10.00m,
                { } => throw new ArgumentException("Not a known vehicle type", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle))
            };
        }
    }
}