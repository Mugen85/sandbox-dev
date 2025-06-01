# ScriptViewerAppWPF 📄

## Descrizione
ScriptViewerAppWPF è una semplice applicazione desktop Windows progettata per visualizzare il contenuto di file di script C# (`.cs`) presenti in una specifica cartella. Offre un'interfaccia utente pulita e intuitiva per navigare tra gli script e leggerne il codice sorgente.

Questa applicazione è stata sviluppata come parte della repository `Sandbox-dev`.

**Anteprima dell'Applicazione:**
![Anteprima di ScriptViewerAppWPF](demo/ScriptViewerAppWPFDemo.gif)

*(English version below)*

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
*Documentazione creata da [Mugen85](https://github.com/Mugen85) il 1 giugno 2025.*
*Ultimo aggiornamento: 1 giugno 2025.*

---
---

## English Version 🇬🇧

# ScriptViewerAppWPF 📄

## Description
ScriptViewerAppWPF is a simple Windows desktop application designed to display the content of C# script files (`.cs`) located in a specific folder. It provides a clean and intuitive user interface for Browse scripts and reading their source code.

This application was developed as part of the `Sandbox-dev` repository.

**Application Preview:**
![ScriptViewerAppWPF Preview](demo/ScriptViewerAppWPFDemo.gif)

## ✨ Key Features
-   Loads and displays a list of script files (`.cs`) from a predefined directory.
-   Shows the full content of the selected script in a dedicated text area.
-   User interface with a two-panel layout (script list and script content) separated by a resizable splitter.
-   Integrated title and description within the interface for a clear understanding of the app's purpose.
-   Developed using C# and Windows Presentation Foundation (WPF) for a modern user experience.

## 🚀 How to Use (User Guide)

### System Requirements
-   Windows Operating System.
-   .NET Desktop Runtime (the specific version depends on the one used to compile the project, e.g., .NET 8.0 or .NET 6.0).

### Launching the Application
Currently, the application is primarily intended to be run from the Visual Studio development environment:
1.  Ensure you have cloned the `Sandbox-dev` repository удовольств this project.
2.  Open the `ScriptViewerAppWPF.sln` solution (located in the `Sandbox-dev/ScriptViewerAppWPF/` folder) using Visual Studio.
3.  Run the project by pressing `F5` or clicking the "Start" button in the Visual Studio toolbar.

### User Interface
The main application window is structured as follows:
1.  **Title and Description Area**: Located at the top of the window, it provides the application's name and a brief explanation of its functionality.
2.  **Script List (Left Panel)**: Displays the names of all script files (`.cs`) found in the designated folder.
3.  **Content Viewer (Right Panel)**: Shows the complete source code of the script currently selected from the list. This area is read-only.
4.  **Vertical Splitter**: A bar positioned between the script list and the content viewer. You can click and drag this splitter to resize the two panels to your liking.

### Operating Instructions
1.  When the application starts, the script list in the left panel will be populated automatically.
2.  Click on any script file name in the list.
3.  The full text content of the selected script will immediately appear in the right panel.
4.  If the script content is extensive, you can use the vertical and horizontal scroll bars in the right panel to navigate it.

## 🛠️ Technical Information (Developer Guide)

### Technologies Used
-   **Programming Language**: C#
-   **UI Framework**: Windows Presentation Foundation (WPF)
-   **Platform**: .NET (e.g., .NET 8.0, .NET 6.0)

### Project Structure
The `ScriptViewerAppWPF` project is located within the `Sandbox-dev` repository, in the `ScriptViewerAppWPF/` subfolder.
-   `MainWindow.xaml`: Defines the entire user interface (layout, controls, styles) using the XAML language.
-   `MainWindow.xaml.cs`: Contains the C# logic (code-behind) associated with `MainWindow`. It handles events, data loading, and user interactions.

### Script Loading Logic
-   **Script Source Folder**: The application is currently configured to read `.cs` files from the following folder, whose path is relative to the root of the `Sandbox-dev` repository:
    `CSharp-LINQPad-Training/github-view/base/`
-   **Absolute Path Determination**: Upon startup, the application calculates the absolute path to this folder. It does this by navigating up the directory structure from the application's execution location (`.../ScriptViewerAppWPF/bin/Debug_or_Release/netX.X/`) until it reaches the root folder of `Sandbox-dev`, and then navigates to the specified script folder. This approach allows the application to function correctly even if the `Sandbox-dev` repository is moved, as long as the internal structure remains unchanged.

### Compilation and Execution from Source
1.  Ensure you have Visual Studio (e.g., 2022 or later) installed, with the ".NET desktop development" workload.
2.  Open the `ScriptViewerAppWPF.sln` solution file.
3.  Choose the desired build configuration (e.g., Debug or Release).
4.  Build the solution (from the `Build > Build Solution` menu or `Ctrl+Shift+B`).
5.  Run the project (by pressing `F5` or from the `Debug > Start Debugging` menu).

## 📍 Location within the `Sandbox-dev` Repository
This project is a component of the `Sandbox-dev` repository and is located at the following path:
`[Sandbox-dev_root]/ScriptViewerAppWPF/`

---
*Documentation created by [Mugen85](https://github.com/Mugen85) on June 1, 2025.*
*Last updated: June 1, 2025.*