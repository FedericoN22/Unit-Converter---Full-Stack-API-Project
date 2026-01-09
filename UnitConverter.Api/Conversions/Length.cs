namespace UnitConverter.Conversions
{
    public static class Length
    {
        private static readonly Dictionary<string, double> ToMeters = new()
        {
            { "mm", 0.001 },
            { "cm", 0.01 },
            { "m", 1.0 },
            { "km", 1000.0 },

            { "inch", 0.0254 },
            { "ft", 0.3048 },
            { "yd", 0.9144 },
            { "mile", 1609.344 }
        };

        public static double Convert(double value, string from, string to)
        {
            from = from.ToLower();
            to = to.ToLower();

            // if (!ToMeters.ContainsKey(from))
            //     throw new ArgumentException($"Unidad de origen no válida: {from}");

            // if (!ToMeters.ContainsKey(to))
            //     throw new ArgumentException($"Unidad de destino no válida: {to}");

            double valueInMeters = value * ToMeters[from];

            double result = valueInMeters / ToMeters[to];

            return result;
        }
    }
}
