// =======================================================================
// File: Automobile.cs
// Pilastri dimostrati: Ereditarietà, Polimorfismo
// Descrizione: Un'altra classe che eredita da Veicolo.
// =======================================================================
namespace PrincipiOOP_CSharp
{
    public class Automobile : Veicolo // --- EREDITARIETÀ ---
    {
        public int NumeroPorte { get; private set; }

        public Automobile(string marca, string modello, int velocitaMassima, int numeroPorte)
            : base(marca, modello, velocitaMassima)
        {
            NumeroPorte = numeroPorte;
            _tipoCarburante = "Diesel";
        }

        // --- POLIMORFISMO: Implementazione specifica del metodo astratto ---
        public override void AvviaMotore()
        {
            Console.WriteLine($"La {Modello} si avvia silenziosamente. Click.");
        }

        // --- POLIMORFISMO: Override del metodo virtuale ---
        public override string OttieniDettagli()
        {
            string dettagliBase = base.OttieniDettagli();
            return $"{dettagliBase} | Porte: {NumeroPorte} | Carburante: {_tipoCarburante}";
        }
    }
}
