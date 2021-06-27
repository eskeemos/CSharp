using NotesOrganizer.Core.Domain;
using NotesOrganizer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotesOrganizer.Infrastructure.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private static readonly ISet<Note> _notes = new HashSet<Note>()
        {
            new Note(Guid.NewGuid(), "Tytuł 1", "Treść 1"),
            new Note(Guid.NewGuid(), "Tytuł 2", "Treść 2")
        };

        public Note Get(Guid Id)
        {
            return _notes.SingleOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Note> GetAll()
        {
            return _notes;
        }

        public Note Add(Note note)
        {
            _notes.Add(note);
            return note;
        }

        public void Update(Note note)
        {
            
        }

        public void Delete(Note note)
        {
            _notes.Remove(note);
        }
    }
}
