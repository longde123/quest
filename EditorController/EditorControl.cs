﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AxeSoftware.Quest
{
    internal class EditorControl : IEditorControl
    {
        private string m_controlType;
        private string m_caption;
        private int? m_height = null;
        private string m_attribute;
        private bool m_expand = false;

        public EditorControl(Element source)
        {
            m_controlType = source.Fields.GetString("controltype");
            m_caption = source.Fields.GetString("caption");
            m_attribute = source.Fields.GetString("attribute");
            if (source.Fields.HasType<int>("height")) m_height = source.Fields.GetAsType<int>("height");
            if (source.Fields.HasType<bool>("expand")) m_expand = source.Fields.GetAsType<bool>("expand");
        }

        #region IEditorControl Members

        public string ControlType
        {
            get { return m_controlType; }
        }

        public string Caption
        {
            get { return m_caption; }
        }

        public int? Height
        {
            get { return m_height; }
        }

        public string Attribute
        {
            get { return m_attribute; }
        }

        public bool Expand
        {
            get { return m_expand; }
        }

        #endregion
    }
}
