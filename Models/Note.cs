using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Note
    {
        
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; } = string.Empty;

        public NoteStatus Status { get; set; } = NoteStatus.Open;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;

        public String? SourceUrl { get; set; }

        public String? OriginalText { get; set; }
    }

    public enum NoteStatus
    {
        Open,
        Completed,
        Dismissed
    }
}
