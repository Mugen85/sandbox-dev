// =======================================================================
// File: Veicolo.cs
// Pilastro dimostrato: Astrazione (e Incapsulamento)
// Descrizione: Classe base ASTRATTA per tutti i veicoli.
//              Definisce un "contratto": ogni veicolo DEVE avere un modo
//              per avviare il motore, ma non specifica come.
// =======================================================================
namespace PrincipiOOP_CSharp
{
    public abstract class Veicolo(string marca, string modello, int velocitaMassima)
    {
        // --- INCAPSULAMENTO: Campi privati e protetti ---
        private int _velocitaAttuale = 0;
        private readonly int _velocitaMassima = velocitaMassima;
        protected string _tipoCarburante = "Sconosciuto";

        // --- INCAPSULAMENTO: Proprietà pubbliche per accesso controllato ---
        public int VelocitaAttuale
        {
            get { return _velocitaAttuale; }
            protected set // 'protected' permette alle classi figlie di modificare la velocità
            {
                if (value < 0) _velocitaAttuale = 0;
                else if (value > _velocitaMassima) _velocitaAttuale = _velocitaMassima;
                else _velocitaAttuale = value;
            }
        }
        public string Marca { get; private set; } = marca;
        public string Modello { get; private set; } = modello;

        // --- ASTRAZIONE: Metodo astratto ---
        // Un metodo astratto non ha implementazione (corpo).
        // Obbliga ogni classe figlia a fornire la propria versione specifica.
        public abstract void AvviaMotore();

        // Metodi concreti condivisi da tutti i veicoli
        public void Accelera(int incremento)
        {
            VelocitaAttuale += incremento;
            Console.WriteLine($"{Marca} {Modello} accelera. Velocità: {VelocitaAttuale} km/h");
        }

        public void Frena(int decremento)
        {
            VelocitaAttuale -= decremento;
            Console.WriteLine($"{Marca} {Modello} frena. Velocità: {VelocitaAttuale} km/h");
        }

        // --- POLIMORFISMO: Metodo virtuale ---
        // 'virtual' permette alle classi figlie di sovrascrivere (override) questo comportamento.
        public virtual string OttieniDettagli()
        {
            return $"Veicolo: {Marca} {Modello} | Vel Max: {_velocitaMassima} km/h";
        }
    }
}