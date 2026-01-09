namespace UnitConverter.Conversions
{
    public static class Weight
    {
        private static readonly Dictionary<string, double> ToGrams = new()
        {
            { "mg", 0.001 },
            { "g", 1.0 },
            { "kg", 1000.0 },
            { "oz", 0.0283495 },
            { "lb", 0.453592 },
        };

        public static double Convert(double value, string from, string to)
        {
            from = from.ToLower();
            to = to.ToLower();

            // if (!ToMeters.ContainsKey(from))
            //     throw new ArgumentException($"Unidad de origen no válida: {from}");

            // if (!ToMeters.ContainsKey(to))
            //     throw new ArgumentException($"Unidad de destino no válida: {to}");

            double valueInGrams = value * ToGrams[from];

            double result = valueInGrams / ToGrams[to];

            return result;
        }
    }
}
