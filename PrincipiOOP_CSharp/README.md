# Progetto dimostrativo sui 4 pilastri della OOP in C#

Questo repository contiene un'applicazione console in C# creata per dimostrare in modo chiaro e pratico i quattro principi fondamentali della Programmazione Orientata agli Oggetti (OOP).

Il progetto è strutturato per essere semplice da comprendere e serve come esempio pratico per chiunque voglia approfondire questi concetti chiave.

## Scopo del progetto

L'obiettivo è fornire un codice sorgente ben commentato che illustri i seguenti pilastri della OOP attraverso un esempio a tema veicoli:

1. **Incapsulamento**
2. **Astrazione**
3. **Ereditarietà**
4. **Polimorfismo**

## I quattro pilastri della OOP

Ogni principio è implementato nel codice come segue:

### 1. Incapsulamento 🔒

L'incapsulamento viene dimostrato nella classe base `Veicolo`. I dati sensibili, come `_velocitaAttuale`, sono `private`, mentre l'accesso è controllato tramite proprietà pubbliche (`public int VelocitaAttuale`). 

Il `set` di questa proprietà è `protected`, garantendo che solo la classe stessa o le sue derivate possano modificare lo stato interno in modo controllato.

```csharp
public abstract class Veicolo
{
    private int _velocitaAttuale;
    
    public int VelocitaAttuale 
    { 
        get => _velocitaAttuale; 
        protected set => _velocitaAttuale = value; 
    }
}
```

### 2. Astrazione 🎭

L'astrazione è rappresentata dalla classe `public abstract class Veicolo`. Essendo astratta, non può essere istanziata direttamente. 

Definisce un "contratto" per tutte le classi derivate attraverso il metodo `public abstract void AvviaMotore()`, che obbliga ogni tipo di veicolo a fornire la propria implementazione specifica per l'avvio.

```csharp
public abstract class Veicolo
{
    public abstract void AvviaMotore();
}
```

### 3. Ereditarietà 🧬

L'ereditarietà è evidente nelle classi `Motocicletta` e `Automobile`, che ereditano dalla classe base `Veicolo` usando la sintassi `: Veicolo`. 

In questo modo, acquisiscono tutte le proprietà e i metodi pubblici e protetti della classe padre, estendendoli con funzionalità specifiche (es. `Cilindrata` per la moto).

```csharp
public class Motocicletta : Veicolo
{
    public int Cilindrata { get; set; }
    
    public override void AvviaMotore()
    {
        // Implementazione specifica per motocicletta
    }
}
```

### 4. Polimorfismo 🎪

Il polimorfismo viene messo in pratica nel file `Program.cs`. Una `List<Veicolo>` contiene oggetti di tipi diversi (`Motocicletta` e `Automobile`). 

Quando si itera sulla lista e si invoca un metodo come `veicolo.AvviaMotore()`, il .NET Runtime seleziona dinamicamente l'implementazione corretta (`override`) a seconda del tipo reale dell'oggetto. Questo permette di trattare oggetti diversi in modo uniforme.

```csharp
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

```

## Struttura del progetto

```
📁 PrincipiOOP_Csharp/
├── 📄 Program.cs
├── 📄 Veicolo.cs
├── 📄 Motocicletta.cs
├── 📄 Automobile.cs
└── 📄 README.md
```

## Diagramma di classe (UML)

Il seguente diagramma UML illustra visivamente la struttura delle classi e le loro relazioni:

![Diagramma UML delle classi](PrincipiOOP_Csharp_UML.png)

*Il diagramma mostra la classe astratta `Veicolo` con i suoi campi privati, proprietà pubbliche e metodi. Le classi `Automobile` e `Motocicletta` ereditano da `Veicolo` e implementano le proprie proprietà e metodi specifici.*

## Come eseguire il progetto

1. **Clonare il repository**
   ```bash
   git clone [URL_DEL_REPOSITORY]
   cd Progetto-OOP-Demo
   ```

2. **Aprire con Visual Studio**
   - Aprire il file `.sln` con Visual Studio
   - Oppure aprire la cartella con Visual Studio Code

3. **Compilare ed eseguire**
   - Impostare il progetto come progetto di avvio
   - Premere `F5` o il pulsante "Avvia" per eseguire l'applicazione console

## Requisiti di sistema

- **.NET 6.0** o versioni successive
- **Visual Studio 2022** (consigliato) o **Visual Studio Code**

## Output di esempio

```
=== Dimostrazione dei 4 Pilastri della OOP ===

--- Benvenuto nel Garage OOP ---

-----------------------------------------
Veicolo: Yamaha XT1200Z Super Ténéré | Vel Max: 210 km/h | Cilindrata: 1200cc | Carburante: Benzina 98 Ottani
La XT1200Z Super Ténéré si avvia con un rombo! Vrooom!
Yamaha XT1200Z Super Ténéré accelera. Velocità: 50 km/h
-----------------------------------------

-----------------------------------------
Veicolo: Fiat Panda | Vel Max: 160 km/h | Porte: 5 | Carburante: Diesel
La Panda si avvia silenziosamente. Click.
Fiat Panda accelera. Velocità: 50 km/h
-----------------------------------------

-----------------------------------------
Veicolo: Ducati Panigale V4 | Vel Max: 300 km/h | Cilindrata: 1103cc | Carburante: Benzina 98 Ottani
La Panigale V4 si avvia con un rombo! Vrooom!
Ducati Panigale V4 accelera. Velocità: 50 km/h
-----------------------------------------
```

## Concetti chiave dimostrati

- ✅ **Incapsulamento**: Controllo dell'accesso ai dati
- ✅ **Astrazione**: Definizione di contratti attraverso classi astratte
- ✅ **Ereditarietà**: Riutilizzo e estensione del codice
- ✅ **Polimorfismo**: Comportamento dinamico basato sul tipo

## Contributi

Sentiti libero di contribuire al progetto creando issue o pull request per miglioramenti e correzioni.

--------------------------------------------------------------

*Progetto creato a scopo didattico per illustrare i principi fondamentali della Programmazione Orientata agli Oggetti in C#*