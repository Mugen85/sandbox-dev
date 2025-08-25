// =======================================================================
// File: Program.cs
// Pilastro dimostrato: Polimorfismo in azione
// Descrizione: Il punto di ingresso che usa le classi create.
// =======================================================================
namespace PrincipiOOP_CSharp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- Benvenuto nel Garage OOP ---\n");

        // --- POLIMORFISMO IN AZIONE ---
        // Creiamo una lista che può contenere qualsiasi
        // oggetto sia un "Veicolo".
        // Grazie all'ereditarietà, possiamo inserire
        // sia Motociclette che Automobili.
        List<Veicolo> garage =
        [
            new Motocicletta("Yamaha", "XT1200Z Super Ténéré", 210, 1200),
            new Automobile("Fiat", "Panda", 160, 5),
            new Motocicletta("Ducati", "Panigale V4", 300, 1103),
        ];

        // Ora iteriamo sulla lista. Il codice non sa se l'oggetto 'veicolo'
        // è una moto o un'auto. Chiama semplicemente i metodi.
        // Il .NET Runtime si occupa di eseguire
        // l'implementazione corretta (override)
        // per ogni oggetto specifico. Questo è il polimorfismo.
        foreach (var veicolo in garage)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(veicolo.OttieniDettagli());
            veicolo.AvviaMotore();
            veicolo.Accelera(50);
            Console.WriteLine("-----------------------------------------\n");
        }

        // Tentativo di creare un Veicolo generico (non compila)
        // Decommenta per vedere l'errore: "Impossibile creare
        // un'istanza della classe astratta o dell'interfaccia 'Veicolo'".
        // Veicolo veicoloGenerico = new Veicolo("Marca", "Modello", 100);
    }
}
