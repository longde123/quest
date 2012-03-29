﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AxeSoftware.Quest;

namespace WebEditor.Models
{
    public class StringDictionary
    {
        public int GameId { get; set; }
        public string Key { get; set; }
        public string Attribute { get; set; }
        public string KeyPrompt { get; set; }
        public IEditableDictionary<string> Value { get; set; }
    }
}