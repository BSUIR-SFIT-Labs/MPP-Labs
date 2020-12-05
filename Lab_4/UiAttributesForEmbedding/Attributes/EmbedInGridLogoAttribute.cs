using System;
using System.Windows;

namespace UiAttributesForEmbedding.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EmbedInGridLogoAttribute : Attribute
    {
        public bool IsEmbedInRectangle { get; set; }

        public HorizontalAlignment HorizontalAlignment { get; set; }

        public VerticalAlignment VerticalAlignment { get; set; }

        public EmbedInGridLogoAttribute(bool isEmbedInRectangle, HorizontalAlignment horizontalAlignment,
            VerticalAlignment verticalAlignment)
        {
            IsEmbedInRectangle = isEmbedInRectangle;
            HorizontalAlignment = horizontalAlignment;
            VerticalAlignment = verticalAlignment;
        }
    }
}