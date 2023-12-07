using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.Mapping.Popups;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Color = System.Drawing.Color;
using SelectionMode = Esri.ArcGISRuntime.Mapping.SelectionMode;

namespace SiTerangMobile.Pages
{
    public partial class PelangganMapPage : ContentPage
    {
        // private string _serviceUrl = "https://38.242.203.160:6443/arcgis/rest/services/jtn/MapServer/1/query?where=objectid%3E0&f=json";
        // private string _serviceUrl = "https://jakartasatu.jakarta.go.id/server/rest/services/BATAS_ADMINSTRASI_RW_DKI_JAKARTA/MapServer/0";
        private string _serviceUrl = "https://sampleserver6.arcgisonline.com/arcgis/rest/services/USA/MapServer/0";
        private ServiceFeatureTable _featureTable;
        private FeatureLayer _featureLayer;
        private ArcGISFeature _selectedFeature;

        public PelangganMapPage()
        {
            InitializeComponent();

            Initialize();
        }
        
        private void Initialize()
        {
            Map map = new Map(BasemapStyle.ArcGISStreets);

            // MapPoint initialLocation = new MapPoint(11897358.334048895, -694800.2689423737, SpatialReferences.WebMercator);
            MapPoint initialLocation = new MapPoint(-11000000, 5000000, SpatialReferences.WebMercator);
            map.InitialViewpoint = new Viewpoint(initialLocation, 100000000);

            _featureTable = new ServiceFeatureTable(new Uri(_serviceUrl));
            _featureLayer = new FeatureLayer(_featureTable)
            {
                IsVisible = true
            };

            SimpleMarkerSymbol markerSymbol = new SimpleMarkerSymbol(SimpleMarkerSymbolStyle.Circle, Color.Purple, 7);
            _featureLayer.Renderer = new SimpleRenderer(markerSymbol);

            map.OperationalLayers.Add(_featureLayer);
            PelangganMapView.SelectionProperties.Color = Color.Cyan;
            PelangganMapView.Map = map;
        }

        private async void OnQueryClicked(object sender, EventArgs e)
        {
            _featureLayer.ClearSelection();

            await QueryStateFeature(queryEntry.Text);
        }

        private async Task QueryStateFeature(string name)
        {
            try
            {
                QueryParameters queryParams = new QueryParameters();
                string formattedName = name.Trim().ToUpper();

                queryParams.WhereClause = "upper(AREANAME) LIKE '%" + formattedName + "%'";

                FeatureQueryResult queryResult = await _featureTable.QueryFeaturesAsync(queryParams);
                List<Feature> features = queryResult.ToList();

                if (features.Any())
                {
                    EnvelopeBuilder envBuilder = new EnvelopeBuilder(SpatialReferences.WebMercator);
                    foreach (Feature feature in features)
                    {
                        envBuilder.UnionOf(feature.Geometry.Extent);
                        _featureLayer.SelectFeature(feature);
                    }
                    await PelangganMapView.SetViewpointGeometryAsync(envBuilder.ToGeometry(), 50);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Area Not Found!", "Add a valid area name.", "OK");
                }
            }
            catch(Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Error!", "An error occured!", "OK");
            }
        }

        private async void PelangganMapTapped(object sender, Esri.ArcGISRuntime.Xamarin.Forms.GeoViewInputEventArgs e)
        {
            try
            {
                _featureLayer.ClearSelection();

                FeatureLayer pelangganLayer = PelangganMapView.Map.OperationalLayers.First() as FeatureLayer;
                IdentifyLayerResult result = await PelangganMapView.IdentifyLayerAsync(pelangganLayer, e.Position, 12, false);

                if (!result.GeoElements.Any())
                {
                        return;
                }

                _selectedFeature = (ArcGISFeature)result.GeoElements.First();
                _featureLayer.SelectFeature(_selectedFeature);
                await Application.Current.MainPage.DisplayAlert("Feature Info",
                                                                "Name   : " + _selectedFeature.Attributes["areaname"].ToString() + "\n" +
                                                                "Class  : " + _selectedFeature.Attributes["class"].ToString() + "\n" +
                                                                "State  : " + _selectedFeature.Attributes["st"].ToString() + "\n" +
                                                                "Pop    : " + _selectedFeature.Attributes["pop2000"].ToString() + "\n",
                                                                "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error!", ex.ToString(), "OK");
            }
            

            /*****
            if (result?.Popups?.FirstOrDefault() is Popup popup)
            {   
                PelangganPopup.IsVisible = true;

                PelangganPopup.PopupManager = new PopupManager(popup);

                QueryParameters queryParams = new QueryParameters
                {
                    Geometry = new Envelope((MapPoint)popup.GeoElement.Geometry, 6, 6)
                };

                await pelangganLayer.SelectFeaturesAsync(queryParams, SelectionMode.New);
            }
            *****/
        }
    }
}