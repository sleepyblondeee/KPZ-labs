﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorLibrary
{
    public class DocumentMemento
    {
        public string Text { get; }

        public DocumentMemento(string text)
        {
            Text = text;
        }
    }
}
