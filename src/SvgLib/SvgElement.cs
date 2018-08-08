using System;
using System.Collections.Generic;
using System.Xml;

namespace SvgLib
{
    public abstract class SvgElement
    {
        protected readonly XmlElement Element;

        protected SvgElement(XmlElement element)
        {
            Element = element ?? throw new ArgumentNullException(nameof(element));
        }

        public string Id
        {
            get => Element.GetAttribute("id");
            set => Element.SetAttribute("id", value);
        }

        public int? TabIndex
        {
            get => Element.GetAttribute("tabindex", (int?)null);
            set => Element.SetAttribute("tabindex", value);
        }

        // TODO Add https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/Presentation

        public string Stroke
        {
            get => Element.GetAttribute("stroke", SvgDefaults.Attributes.FillAndStroke.Stroke);
            set => Element.SetAttribute("stroke", value);
        }

        public bool Visible
        {
            get => GetStyle("display") != "none";
            set => SetStyle("display", value ? string.Empty : "none");
        }

        public IEnumerable<string> GetClasses() => throw new NotImplementedException();

        public bool HasClass(string name) => throw new NotImplementedException();

        public void AddClass(string name) => throw new NotImplementedException();

        public void RemoveClass(string name) => throw new NotImplementedException();

        public void ToggleClass(string name)
        {
            if (HasClass(name)) RemoveClass(name);
            else AddClass(name);
        }

        private string GetStyle(string name)
        {
            throw new NotImplementedException();
        }

        private void SetStyle(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}
