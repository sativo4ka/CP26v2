using System;

namespace CP26v2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ReferenceCache<string>");

            ReferenceCache<string> referenceCache = new ReferenceCache<string>();

            bool referenceResult = referenceCache.TryGet(out string? text);

            Console.WriteLine($"Промах: {referenceResult}, значение: {text ?? "null"}");

            referenceCache.Set("Привет!");

            referenceResult = referenceCache.TryGet(out text);

            Console.WriteLine($"Попадание: {referenceResult}, значение: {text}");

            Console.WriteLine();
            Console.WriteLine("ValueCache<double>");

            ValueCache<double> valueCache = new ValueCache<double>();

            bool valueResult = valueCache.TryGet(out double? number);

            Console.WriteLine($"Промах: {valueResult}, значение: {number?.ToString() ?? "null"}");

            valueCache.Set(15.75);

            valueResult = valueCache.TryGet(out number);

            Console.WriteLine($"Попадание: {valueResult}, значение: {number}");

        }
    }
}