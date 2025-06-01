using System.IO; // Necessario per lavorare con File e Directory
using System.Windows;
using System.Windows.Controls; // Necessario per SelectionChangedEventArgs

namespace ScriptViewerAppWPF 
{
    public partial class MainWindow : Window 
    {
        // Percorso relativo alla cartella degli script dalla radice della repository Sandbox-dev
        private readonly string scriptsRelativePath = Path.Combine("CSharp-LINQPad-Training", "github-view", "base");
        private string? scriptsFolderPath; // Reso nullable per la null-safety di C#

        public MainWindow()
        {
            InitializeComponent();
            LoadScripts();
            // Dopo LoadScripts, scriptsFolderPath dovrebbe essere inizializzato se la cartella esiste
        }

        private void LoadScripts()
        {
            try
            {
                string appBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string sandboxRootPath = Path.GetFullPath(Path.Combine(appBaseDirectory, "..", "..", "..", ".."));
                scriptsFolderPath = Path.Combine(sandboxRootPath, scriptsRelativePath); // Assegnazione

                scriptsListBox.Items.Clear();

                if (!string.IsNullOrEmpty(scriptsFolderPath) && Directory.Exists(scriptsFolderPath))
                {
                    IEnumerable<string> scriptFiles = Directory.EnumerateFiles(scriptsFolderPath, "*.cs");

                    if (scriptFiles.Any())
                    {
                        foreach (string filePath in scriptFiles)
                        {
                            scriptsListBox.Items.Add(Path.GetFileName(filePath));
                        }
                    }
                    else
                    {
                        scriptContentTextBox.Text = $"Nessun file .cs trovato nella cartella:\n{scriptsFolderPath}";
                    }
                }
                else
                {
                    // Usa una stringa di fallback se scriptsFolderPath è null o vuoto qui
                    string pathToDisplay = string.IsNullOrEmpty(scriptsFolderPath) ? "Percorso non calcolabile" : scriptsFolderPath;
                    MessageBox.Show($"La cartella degli script non è stata trovata al percorso:\n{pathToDisplay}\n\nAssicurati che la struttura della cartella Sandbox-dev sia corretta e che il progetto ScriptViewerAppWPF sia al suo interno.", "Errore Cartella Script", MessageBoxButton.OK, MessageBoxImage.Error);
                    scriptContentTextBox.Text = $"Cartella non trovata:\n{pathToDisplay}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore durante il caricamento degli script:\n{ex.Message}", "Errore Caricamento Script", MessageBoxButton.OK, MessageBoxImage.Error);
                scriptContentTextBox.Text = $"Errore durante il caricamento degli script:\n{ex}";
            }
        }
       
        private void ScriptsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (scriptsListBox.SelectedItem != null)
            {
                // Verifica se scriptsFolderPath è stato correttamente inizializzato
                if (string.IsNullOrEmpty(scriptsFolderPath))
                {
                    scriptContentTextBox.Text = "Errore: Il percorso della cartella degli script non è stato inizializzato correttamente.";
                    return;
                }

                try
                {
                    // Assumiamo che SelectedItem.ToString() non sia null perché aggiungiamo stringhe non nulle
                    string selectedFileName = scriptsListBox.SelectedItem.ToString()!;
                    string fullFilePath = Path.Combine(scriptsFolderPath, selectedFileName); // scriptsFolderPath qui non dovrebbe essere null

                    if (File.Exists(fullFilePath))
                    {
                        scriptContentTextBox.Text = File.ReadAllText(fullFilePath);
                    }
                    else
                    {
                        scriptContentTextBox.Text = $"File '{selectedFileName}' non trovato nel percorso previsto.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Si è verificato un errore durante la lettura del file:\n{ex.Message}", "Errore Lettura File", MessageBoxButton.OK, MessageBoxImage.Error);
                    scriptContentTextBox.Text = $"Errore durante la lettura del file '{scriptsListBox.SelectedItem}':\n{ex}";
                }
            }
            else
            {
                scriptContentTextBox.Text = ""; // Pulisci se nessun item è selezionato
            }
        }
    }
}