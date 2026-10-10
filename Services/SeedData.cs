using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class SeedData
    {
        public List<Note> GetSeedNotes()
        {
            List<Note> seedNotes = new List<Note>
            {
                new Note
                {
                    Text = "Love Hershey with all your heart.",
                    Status = NoteStatus.Open,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                },
                new Note
                {
                    Text = "Give her the best life she deserves.",
                    Status = NoteStatus.Open,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                },
                new Note
                {
                    Text = "Be the best version of yourself.",
                    Status = NoteStatus.Open,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                },
                new Note
                {
                    Text = "Be kind to everyone you meet.",
                    Status = NoteStatus.Open,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                },
                new Note
                {
                    Text = "Be grateful for what you have.",
                    Status = NoteStatus.Open,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow
                },
            };

            return seedNotes;
        }
        
    }
}
