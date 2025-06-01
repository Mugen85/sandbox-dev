# 🤩 TaskManagerConsole

Un'applicazione console scritta in C# per la gestione semplice di task.  
Questa versione è stata **rifattorizzata seguendo i principi dell'architettura software**, per essere più pulita, scalabile e facilmente manutenibile.

---

## 🚀 Funzionalità

- ✅ Visualizza l'elenco dei task
- ➕ Aggiunge nuovi task tramite input da tastiera
- 📝 Segna un task come completato specificando il suo ID
- ❌ Esce in sicurezza (funzionalità estendibile con salvataggio su file)

---

## 🧠 Concetti C# e best practice utilizzate

Questo progetto è stato progettato in ottica architetturale, con l'obiettivo di applicare le migliori pratiche dello sviluppo software:

- **Separazione delle responsabilità** (principio SRP)
- Uso di **classi dedicate** per logica (`TaskManager`) e dati (`TaskItem`)
- Utilizzo di **Dictionary<int, Action>** al posto del classico `switch`, per rendere il codice più elegante, ordinato e facilmente estendibile
- **Chiamate dinamiche di metodi** tramite l’uso di deleghe (`Action`) che permettono di associare e invocare metodi in modo flessibile
- **Codice pulito, leggibile e pronto per essere testato**

---

## 🏗️ Struttura del progetto

```
TaskManagerConsole/
├── Program.cs                // Contiene il punto di ingresso Main()
├── TaskManager.cs            // Classe principale che gestisce l'interfaccia e la logica dei task
├── TaskItem.cs               // Modello dati dei singoli task (Id, Titolo, Completato)
├── TaskManagerConsole.csproj // File di progetto .NET
├── README.md                 // Documentazione del progetto
```

---

## 🔠 Prossimi step

Questo progetto sarà esteso con:

- 📂 Salvataggio su file locale (TXT/JSON)
- 📊 Generazione di report dei task completati e non
- 🧪 Test unitari per validare la logica della classe `TaskManager`
- 🔄 Possibile evoluzione verso un'API REST con ASP.NET Core
- 🛡️ Gestione degli input con blocchi `try-catch` per intercettare e gestire errori in modo sicuro

---

## 🧑‍💻 Per chi è pensato

- Chi sta imparando C# e vuole fare esercizio con un progetto reale
- Studenti che vogliono applicare le basi della programmazione ad oggetti
- Sviluppatori junior che vogliono migliorare nella scrittura di codice pulito
- Chi vuole iniziare a ragionare come un **architetto software**

---

## 📬 Contatti

Sviluppato da **[@Mugen85](https://github.com/Mugen85)**  
Se ti è stato utile, ⭐ lascia una stella al repository!

