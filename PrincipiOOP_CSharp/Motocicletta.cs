// =======================================================================
// File: Motocicletta.cs
// Pilastri dimostrati: Ereditarietà, Polimorfismo
// Descrizione: Eredita da Veicolo e fornisce implementazioni specifiche.
// =======================================================================
namespace PrincipiOOP_CSharp
{
    public class Motocicletta : Veicolo // --- EREDITARIETÀ ---
    {
        public int Cilindrata { get; private set; }

        // Il costruttore chiama quello della classe base con ': base(...)'
        public Motocicletta(string marca, string modello, int velocitaMassima, int cilindrata)
            : base(marca, modello, velocitaMassima)
        {
            Cilindrata = cilindrata;
            _tipoCarburante = "Benzina 98 Ottani"; // Accede al campo protected
        }

        // --- POLIMORFISMO: Implementazione del metodo astratto ---
        public override void AvviaMotore()
        {
            Console.WriteLine($"La {Modello} si avvia con un rombo! Vrooom!");
        }

        // --- POLIMORFISMO: Override del metodo virtuale ---
        public override string OttieniDettagli()
        {
            string dettagliBase = base.OttieniDettagli();
            return $"{dettagliBase} | Cilindrata: {Cilindrata}cc | Carburante: {_tipoCarburante}";
        }
    }
}