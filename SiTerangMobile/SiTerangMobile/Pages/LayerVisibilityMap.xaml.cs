using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Esri.ArcGISRuntime.Mapping;

namespace SiTerangMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayerVisibilityMap : ContentPage
    {
        private ArcGISMapImageLayer _imageLayer;

        public LayerVisibilityMap()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Map myMap = new Map();

            Uri serviceUri = new Uri("https://sampleserver6.arcgisonline.com/arcgis/rest/services/SampleWorldCities/MapServer");

            _imageLayer = new ArcGISMapImageLayer(serviceUri)
            {
                Name = "World Cities Population"
            };

            myMap.Basemap.BaseLayers.Add(_imageLayer);

            LayerVisibilityView.Map = myMap;
        }

        private async void OnSublayersClicked(object sender, EventArgs e)
        {
            try
            {
                await _imageLayer.LoadAsync();
                StackLayout layout = new StackLayout();
                TableView sublayersTableView = new TableView();
                TableSection sublayersSection = new TableSection(_imageLayer.Name);

                foreach (ArcGISSublayer sublayer in _imageLayer.Sublayers)
                {
                    SwitchCell cell = new SwitchCell()
                    {
                        Text = sublayer.Name,
                        On = sublayer.IsVisible
                    };
                    cell.OnChanged += OnCellOnOffChanged;
                    sublayersSection.Add(cell);
                }

                sublayersTableView.Root.Add(sublayersSection);
                layout.Children.Add(sublayersTableView);

                ContentPage sublayersPage = new ContentPage()
                {
                    Content = layout,
                    Title = "Sublayers"
                };

                await Navigation.PushAsync(sublayersPage);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "OK");
            }
        }

        private void OnCellOnOffChanged(object sender, ToggledEventArgs e)
        {
            SwitchCell cell = (SwitchCell)sender;
            ArcGISSublayer sublayer = _imageLayer.Sublayers.First(x => x.Name == cell.Text);

            sublayer.IsVisible = e.Value;
        }
    }
}