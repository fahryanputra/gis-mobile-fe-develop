//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SiTerangMobile.Pages.LayerVisibilityMap.xaml", "Pages/LayerVisibilityMap.xaml", typeof(global::SiTerangMobile.Pages.LayerVisibilityMap))]

namespace SiTerangMobile.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\LayerVisibilityMap.xaml")]
    public partial class LayerVisibilityMap : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button SublayerButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Esri.ArcGISRuntime.Xamarin.Forms.MapView LayerVisibilityView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(LayerVisibilityMap));
            SublayerButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "SublayerButton");
            LayerVisibilityView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Esri.ArcGISRuntime.Xamarin.Forms.MapView>(this, "LayerVisibilityView");
        }
    }
}
