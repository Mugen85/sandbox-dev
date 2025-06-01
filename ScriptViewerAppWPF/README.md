# ScriptViewerAppWPF 📄

## Descrizione
ScriptViewerAppWPF è una semplice applicazione desktop Windows progettata per visualizzare il contenuto di file di script C# (`.cs`) presenti in una specifica cartella. Offre un'interfaccia utente pulita e intuitiva per navigare tra gli script e leggerne il codice sorgente.

Questa applicazione è stata sviluppata come parte della repository `Sandbox-dev`.

## ✨ Funzionalità Principali
-   Carica e visualizza un elenco di file script (`.cs`) da una directory predefinita.
-   Mostra il contenuto completo dello script selezionato in un'area di testo dedicata.
-   Interfaccia utente con layout a due pannelli (lista script e contenuto script) separati da un divisore ridimensionabile.
-   Titolo e descrizione integrati nell'interfaccia per una chiara comprensione dello scopo dell'app.
-   Sviluppata utilizzando C# e Windows Presentation Foundation (WPF) per un'esperienza utente moderna.

## 🚀 Come Usare (Guida per l'Utente)

### Requisiti di Sistema
-   Sistema Operativo Windows.
-   .NET Desktop Runtime (la versione specifica dipende da quella utilizzata per compilare il progetto, ad esempio, .NET 8.0 o .NET 6.0).

### Avvio dell'Applicazione
Attualmente, l'applicazione è intesa per essere eseguita principalmente dall'ambiente di sviluppo Visual Studio:
1.  Assicurati di aver clonato la repository `Sandbox-dev` che contiene questo progetto.
2.  Apri la soluzione `ScriptViewerAppWPF.sln` (che si trova nella cartella `Sandbox-dev/ScriptViewerAppWPF/`) utilizzando Visual Studio.
3.  Avvia il progetto premendo `F5` o cliccando sul pulsante "Start" nella barra degli strumenti di Visual Studio.

### Interfaccia Utente
La finestra principale dell'applicazione è strutturata come segue:
1.  **Area Titolo e Descrizione**: Situata nella parte superiore della finestra, fornisce il nome dell'applicazione e una breve spiegazione del suo funzionamento.
2.  **Elenco Script (Pannello Sinistro)**: Visualizza i nomi di tutti i file script (`.cs`) trovati nella cartella designata.
3.  **Visualizzatore Contenuto (Pannello Destro)**: Mostra il codice sorgente completo dello script attualmente selezionato dall'elenco. Quest'area è di sola lettura.
4.  **Divisore Verticale**: Una barra posizionata tra l'elenco degli script e il visualizzatore del contenuto. Puoi cliccare e trascinare questo divisore per ridimensionare i due pannelli a tuo piacimento.

### Istruzioni Operative
1.  All'avvio dell'applicazione, l'elenco degli script nel pannello sinistro verrà popolato automaticamente.
2.  Clicca su un qualsiasi nome di file script nell'elenco.
3.  Il contenuto testuale completo dello script selezionato apparirà immediatamente nel pannello di destra.
4.  Se il contenuto dello script è esteso, puoi utilizzare le barre di scorrimento verticali e orizzontali nel pannello di destra per navigarlo.

## 🛠️ Informazioni Tecniche (Guida per Sviluppatori)

### Tecnologie Utilizzate
-   **Linguaggio di Programmazione**: C#
-   **Framework UI**: Windows Presentation Foundation (WPF)
-   **Piattaforma**: .NET (es. .NET 8.0, .NET 6.0)

### Struttura del Progetto
Il progetto `ScriptViewerAppWPF` si trova all'interno della repository `Sandbox-dev`, nella sottocartella `ScriptViewerAppWPF/`.
-   `MainWindow.xaml`: Definisce l'intera interfaccia utente (layout, controlli, stili) utilizzando il linguaggio XAML.
-   `MainWindow.xaml.cs`: Contiene la logica C# (code-behind) associata alla `MainWindow`. Gestisce eventi, caricamento dei dati, e interazioni utente.

### Logica di Caricamento degli Script
-   **Cartella Sorgente degli Script**: L'applicazione è attualmente configurata per leggere i file `.cs` dalla seguente cartella, il cui percorso è relativo alla radice della repository `Sandbox-dev`:
    `CSharp-LINQPad-Training/github-view/base/`
-   **Determinazione del Percorso Assoluto**: Al momento dell'avvio, l'applicazione calcola il percorso assoluto di questa cartella. Lo fa risalendo la struttura delle directory dalla posizione dell'eseguibile (`.../ScriptViewerAppWPF/bin/Debug_o_Release/netX.X/`) fino a raggiungere la cartella radice di `Sandbox-dev`, per poi navigare fino alla cartella degli script specificata. Questo approccio permette all'applicazione di funzionare correttamente anche se la repository `Sandbox-dev` viene spostata, purché la struttura interna rimanga invariata.

### Compilazione ed Esecuzione da Sorgente
1.  Assicurati di avere Visual Studio (es. 2022 o successivo) installato, con i workload per lo "Sviluppo di applicazioni desktop .NET".
2.  Apri il file di soluzione `ScriptViewerAppWPF.sln`.
3.  Scegli la configurazione di build desiderata (ad esempio, Debug o Release).
4.  Compila la soluzione (dal menu `Build > Compila soluzione` o `Ctrl+Shift+B`).
5.  Esegui il progetto (premendo `F5` o dal menu `Debug > Avvia debug`).

## 📍 Posizione all'interno della Repository `Sandbox-dev`
Questo progetto è un componente della repository `Sandbox-dev` e si trova nel seguente percorso:
`[Sandbox-dev_root]/ScriptViewerAppWPF/`

---
*Documentazione creata da [Mugen85](https://github.com/Mugen85) il <01/06/2025>.*
*Ultimo aggiornamento: <01/06/2025>*