using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        private readonly List<string> _parts = new();
        private readonly string _carType;

        public Car(string carType)
        {
            _carType = carType;
        }
        public void AddPart(string part)
        {
            _parts.Add(part);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in _parts)
            {
                sb.Append($"Car of type {_carType} has parts {part}");
            }
            return sb.ToString();
        }
    }
}
