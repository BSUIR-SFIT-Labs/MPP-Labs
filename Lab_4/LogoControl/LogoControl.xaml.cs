using System.Windows;
using System.Windows.Controls;
using UiAttributesForEmbedding.Attributes;

namespace LogoControl
{
    [EmbedInGridLogo(true, HorizontalAlignment.Center, VerticalAlignment.Center)]
    public partial class LogoControl : UserControl
    {
        public LogoControl()
        {
            InitializeComponent();
        }
    }
}