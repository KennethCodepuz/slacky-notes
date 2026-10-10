using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Models;
using MyApp.Services;

namespace MyApp.ViewModels
{
    public class NotesViewModel
    {
        public ObservableCollection<Note> Notes { get; set; } = new();
        public NotesViewModel()
        {
            SeedData seedData = new SeedData();
            var seedNotes = seedData.GetSeedNotes();
            foreach (var note in seedNotes)
            {
                Notes.Add(note);
            }
            HasNotes = Notes.Count > 0;

            CurrentNote = seedData.GetSeedNotes().Count == 0 ? null : Notes[0];
        }

        public Note? CurrentNote { get; set; }

        public int CurrentIndex
        {
            get
            {
                if (CurrentNote == null) return -1;
                return Notes.IndexOf(CurrentNote);
            }
        }

        public int NoteCount => Notes.Count;

        public bool HasNotes { get; set; } = false;
    }
}
