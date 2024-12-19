using System.Collections.Generic;
using System.Linq;

namespace ForwardCheckingOrar
{
    class Sala
    {
        public string Nume { get; set; }
        public List<(int Start, int End)> IntervaleRezervate { get; set; } = new List<(int Start, int End)>();

        public override string ToString()
        {
            if (IntervaleRezervate.Count == 0)
            {
                return $"{Nume} (Libera)";
            }

            var rezervari = string.Join(", ", IntervaleRezervate.Select(i => $"{i.Start}-{i.End}"));
            return $"{Nume} (Rezervata: {rezervari})";
        }
    }
}