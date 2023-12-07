using Android.App;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Javax.Net.Ssl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Android.Net;

namespace SiTerangMobile.Droid
{
    internal class BypassSslValidationClientHandler : AndroidClientHandler
    {
        protected override SSLSocketFactory ConfigureCustomSSLSocketFactory(HttpsURLConnection connection)
        {
            return SSLCertificateSocketFactory.GetInsecure(1000, null);
            // return null;
        }

        protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection)
        {
            return new BypassHostNameVerifier();
        }
    }
}