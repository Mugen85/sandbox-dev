
internal class Program
{
    private static void Main(string[] args)
    {
        TaskManager manager = new();
        manager.Avvia();
    }
}

public class TaskManager
{
    private List<TaskItem> tasks = new()
    {
        new TaskItem { Id = 1, Titolo = "studio", Completato = false },
        new TaskItem { Id = 2, Titolo = "allenamento", Completato = false },
        new TaskItem { Id = 3, Titolo = "lavoro", Completato = false }
    };

    private int nextId = 3;

    private readonly Dictionary<int, Action> menu;

    public TaskManager()
    {
        menu = new Dictionary<int, Action>
        {
            [1] = VisualizzaTask,
            [2] = AggiungiTask,
            [3] = CompletaTask,
            [4] = () => Console.WriteLine("Uscita in corso...")
        };
    }

    public void Avvia()
    {
        int scelta = 0;

        while (scelta != 4)
        {
            MostraMenu();
            string? input = Console.ReadLine();
            int.TryParse(input, out scelta);

            if (menu.ContainsKey(scelta))
                menu[scelta].Invoke();
            else
                Console.WriteLine("❌ Scelta non valida.");
        }
    }

    private void MostraMenu()
    {
        Console.WriteLine("\n--- Menu ---");
        Console.WriteLine("1 - Visualizza tutti i task");
        Console.WriteLine("2 - Aggiungi un nuovo task");
        Console.WriteLine("3 - Segna un task come completato");
        Console.WriteLine("4 - Esci");
    }

    private void VisualizzaTask()
    {
        Console.WriteLine("\n📋 Elenco Task:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("Nessun task presente.");
            return;
        }

        foreach (var task in tasks)
        {
            string stato = task.Completato ? "✅ Completato" : "❌ Da fare";
            Console.WriteLine($"Task {task.Id}: {task.Titolo} - {stato}");
        }
    }

    private void AggiungiTask()
    {
        Console.WriteLine("Inserisci il titolo del nuovo task:");
        string? titolo = Console.ReadLine();

        tasks.Add(new TaskItem
        {
            Id = ++nextId,
            Titolo = titolo ?? "Task senza nome",
            Completato = false
        });

        Console.WriteLine($"✅ Task aggiunto con ID {nextId}");
    }

    private void CompletaTask()
    {
        Console.WriteLine("Inserisci l'ID del task da completare:");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int id))
        {
            Console.WriteLine("❌ ID non valido.");
            return;
        }

        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.Completato = true;
            Console.WriteLine($"✅ Task con ID {id} completato.");
        }
        else
        {
            Console.WriteLine($"❌ Nessun task trovato con ID {id}.");
        }
    }
}

public class TaskItem
{
    public int Id { get; set; }
    public string? Titolo { get; set; }
    public bool Completato { get; set; }
}


