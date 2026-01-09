namespace UnitConverter.Conversions
{
    public static class Temperature
    {
        private static readonly Dictionary<string, double> ToKelvin = new()
        {
            { "k", 1.0 },
            { "f", 0.555556 },
            { "c", 1.0 },
        };

        public static double Convert(double value, string from, string to)
        {
            from = from.ToLower();
            to = to.ToLower();

            // if (!ToMeters.ContainsKey(from))
            //     throw new ArgumentException($"Unidad de origen no válida: {from}");

            // if (!ToMeters.ContainsKey(to))
            //     throw new ArgumentException($"Unidad de destino no válida: {to}");

            double valueInKelvin = value * ToKelvin[from];

            double result = valueInKelvin / ToKelvin[to];

            return result;
        }
    }
}
