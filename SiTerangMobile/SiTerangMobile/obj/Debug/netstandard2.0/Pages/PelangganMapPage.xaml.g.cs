//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("SiTerangMobile.Pages.PelangganMapPage.xaml", "Pages/PelangganMapPage.xaml", typeof(global::SiTerangMobile.Pages.PelangganMapPage))]

namespace SiTerangMobile.Pages {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\PelangganMapPage.xaml")]
    public partial class PelangganMapPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry queryEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Esri.ArcGISRuntime.Xamarin.Forms.MapView PelangganMapView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Esri.ArcGISRuntime.Toolkit.Xamarin.Forms.PopupViewer PelangganPopup;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PelangganMapPage));
            queryEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "queryEntry");
            PelangganMapView = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Esri.ArcGISRuntime.Xamarin.Forms.MapView>(this, "PelangganMapView");
            PelangganPopup = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Esri.ArcGISRuntime.Toolkit.Xamarin.Forms.PopupViewer>(this, "PelangganPopup");
        }
    }
}