using System;

namespace UiAttributesForEmbedding.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EmbedInTabControlAttribute : Attribute
    {
        public bool IsEmbedInTabControl { get; set; }

        public string Header { get; set; }

        public EmbedInTabControlAttribute(bool isEmbedInTabControl, string header)
        {
            IsEmbedInTabControl = isEmbedInTabControl;
            Header = header;
        }
    }
}