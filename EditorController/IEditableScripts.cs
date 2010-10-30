﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AxeSoftware.Quest
{
    public class EditableScriptsUpdatedEventArgs : EventArgs
    {
        internal EditableScriptsUpdatedEventArgs()
        {
        }

        internal EditableScriptsUpdatedEventArgs(IEditableScript updatedScript, EditableScriptUpdatedEventArgs args)
        {
            UpdatedScript = updatedScript;
            UpdatedScriptEventArgs = args;
        }        

        public IEditableScript UpdatedScript { get; private set; }
        public EditableScriptUpdatedEventArgs UpdatedScriptEventArgs { get; private set; }
    }

    public interface IEditableScripts
    {
        IEnumerable<IEditableScript> Scripts { get; }
        void AddNew(string keyword, string elementName);
        IEditableScript this[int index] { get; }
        event EventHandler<EditableScriptsUpdatedEventArgs> Updated;
        void Remove(int index);
        string DisplayString();
        string DisplayString(int index, string newValue);
    }
}
