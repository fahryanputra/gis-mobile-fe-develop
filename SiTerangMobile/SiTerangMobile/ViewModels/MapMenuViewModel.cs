using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SiTerangMobile.ViewModels
{
    internal class MapMenuViewModel
    {
        public IList<MapMenuItem> Items { get; set; }

        public MapMenuViewModel()
        {
            Items = new List<MapMenuItem>();

            Items.Add(new MapMenuItem
            {
                Label = "Peta Jaringan",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu01.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Peta Listrik Jakarta",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu02.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Pelanggan Sekitar",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu03.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Pelanggan Kode \"N\"",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu04.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Pelanggan P2TL",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu05.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Peta Tunggakan",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu06.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Potensi Pasar",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu07.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Peta AMR",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu08.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Peta Lokasi SPLU",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu09.png}"
            });
            Items.Add(new MapMenuItem
            {
                Label = "Pascabayar/prabayar",
                ImageResource = "{local:ImageResource SiTerangMobile.Assets.Menu.menu10.png}"
            });
        }
    }
}
