using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void SetTheme( string name )
        {
            //var sharedResourceDictionary = new ResourceDictionary() { Source = new Uri( $"Themes/Shared.xaml", UriKind.Relative ) };
            //var resourceDictionary = new ResourceDictionary() { Source = new Uri( $"Themes/{name}.xaml", UriKind.Relative ) };

            //Resources.Clear();
            //Resources.MergedDictionaries.Clear();

            ////Resources.MergedDictionaries.Add( sharedResourceDictionary );
            //Resources.MergedDictionaries.Add( resourceDictionary );

            var sharedResourceDictionary = new ResourceDictionary() { Source = new Uri( $"Themes/Shared.xaml", UriKind.Relative ) };
            var resourceDictionary = new ResourceDictionary() { Source = new Uri( $"Themes/{name}.xaml", UriKind.Relative ) };
            var resources = new ResourceDictionary();

            resources.MergedDictionaries.Add( sharedResourceDictionary );
            resources.MergedDictionaries.Add( resourceDictionary );

            this.Resources = resources;
        }
    }
}
