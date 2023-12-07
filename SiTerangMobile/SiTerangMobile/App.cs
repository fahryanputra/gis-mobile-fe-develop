using Esri.ArcGISRuntime;
using Esri.ArcGISRuntime.Data;
using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Location;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Security;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.Tasks;
using Esri.ArcGISRuntime.UI;
using SiTerangMobile.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Xamarin.Forms;

namespace SiTerangMobile
{
    public class App : Xamarin.Forms.Application
    {
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            //****************
            // Authentication for ArcGIS location services:
            // Use of ArcGIS location services, including basemaps and geocoding, requires either:
            // 1) ArcGIS identity (formerly named user): An account that is a member of an organization in ArcGIS Online or ArcGIS Enterprise
            //    giving your application permission to access the content and location services authorized to an existing ArcGIS user's account.
            // 2) API key: A permanent token that grants your application access to ArcGIS location services.
            //    Create a new API key or access existing API keys from your ArcGIS for Developers
            //    dashboard (https://links.esri.com/arcgis-api-keys) then set:
            ArcGISRuntimeEnvironment.ApiKey = "AAPK67bf937dcadd455095a0bc9c174f027a-EcK-utQsDjCtcETrShs-z6l_rmrt0HmzTXhWtIdu43pC_Ud4HyPN5mht6mG2uTS";
            // For more information see https://links.esri.com/arcgis-runtime-security-auth.
            //
            // Licensing:
            // Production deployment of applications built with ArcGIS Runtime requires you to license ArcGIS Runtime functionality.
            // For more information see https://links.esri.com/arcgis-runtime-license-and-deploy.
            //   ArcGISRuntimeEnvironment.SetLicense(string licenseString);
            // or 
            //   ArcGISRuntimeEnvironment.SetLicense(await myArcGISPortal.GetLicenseInfoAsync());
            //****************

            // Initialize the ArcGIS Runtime before any components are created.
            ArcGISRuntimeEnvironment.Initialize();

            // The root page of your application
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
                // MainPage = new HomePage();
            } else
            {
                MainPage = new HomePage();
            }
        }
    }
}
