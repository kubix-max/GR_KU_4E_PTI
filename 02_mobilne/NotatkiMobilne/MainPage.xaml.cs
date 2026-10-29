using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Notatki { get; set; }

    public MainPage()
    {
        InitializeComponent();

        
        Notatki =
        [
            "W piatek jest swieto szkoly",
            "Zdalem prawo jazdy",
            "Mam osmioletni komputer"
        ];

        BindingContext = this;
    }

    private void OnAddButtonClicked(object? sender, EventArgs e)
    {
        string? NowaNotatka = NoteEntry.Text?.Trim();
        if (!string.IsNullOrEmpty(NowaNotatka))
        {
            Notatki.Add(NowaNotatka);
            NoteEntry.Text = string.Empty;
        }
    }
}