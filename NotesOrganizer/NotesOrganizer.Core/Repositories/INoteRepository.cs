﻿using NotesOrganizer.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotesOrganizer.Core.Repositories
{
    public interface INoteRepository
    {
        Note Get(Guid Id);
        IEnumerable<Note> GetAll();
        Note Add(Note note);
        void Update(Note note);
        void Delete(Note note);
    }
}
