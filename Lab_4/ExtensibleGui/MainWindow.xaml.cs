using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UiAttributesForEmbedding.Attributes;

namespace ExtensibleGui
{
    public partial class MainWindow : Window
    {
        private const string PathToPluginFolder = "./Plugins";

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                LoadPlugins(PathToPluginFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private static IEnumerable<FileInfo> GetPluginsInfo(string pathToPluginFolder)
        {
            if (!Directory.Exists(pathToPluginFolder))
            {
                throw new DirectoryNotFoundException("Plugins directory doesn't exist");
            }

            return new DirectoryInfo(pathToPluginFolder).GetFiles();
        }

        private void LoadPlugins(string pathToPluginFolder)
        {
            foreach (var plugin in GetPluginsInfo(pathToPluginFolder))
            {
                Assembly pluginAssembly = null;

                try
                {
                    pluginAssembly = Assembly.LoadFile(plugin.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to load assembly {plugin.Name}: {ex}", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }

                if (pluginAssembly != null)
                {
                    HandlePluginAssembly(pluginAssembly);
                }
            }
        }

        private void HandlePluginAssembly(Assembly assembly)
        {
            var assemblyTypes = assembly.GetTypes();

            foreach (var type in assemblyTypes)
            {
                if (type.BaseType == typeof(UserControl))
                {
                    HandleEmbedUserControl(type);
                }
            }
        }

        private void HandleEmbedUserControl(Type type)
        {
            var attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                switch (attribute)
                {
                    case EmbedInTabControlAttribute embedInTabControlAttribute:
                        HandleAttribute(embedInTabControlAttribute, type);
                        break;
                    case EmbedInGridLogoAttribute embedInRectangleAttribute:
                        HandleAttribute(embedInRectangleAttribute, type);
                        break;
                }
            }
        }

        private void HandleAttribute(EmbedInTabControlAttribute embedInTabControlAttribute, Type type)
        {
            var registrationControl = (UserControl)type.GetConstructor(new Type[0])?.Invoke(null);

            if (embedInTabControlAttribute.IsEmbedInTabControl)
            {
                var registrationTabItem = new TabItem
                {
                    Header = embedInTabControlAttribute.Header,
                    Content = new Grid
                    {
                        Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)),
                        Children = {registrationControl ?? throw new InvalidOperationException()}
                    }
                };

                TControl.Items.Add(registrationTabItem);
            }
        }

        private void HandleAttribute(EmbedInGridLogoAttribute embedInGridLogoAttribute, Type type)
        {
            var logoControl = (UserControl)type.GetConstructor(new Type[0])?.Invoke(null);

            if (logoControl != null)
            {
                logoControl.HorizontalAlignment = embedInGridLogoAttribute.HorizontalAlignment;
                logoControl.VerticalAlignment = embedInGridLogoAttribute.VerticalAlignment;

                if (embedInGridLogoAttribute.IsEmbedInRectangle)
                {
                    GridLogo.Children.Add(logoControl);
                }
            }
        }
    }
}