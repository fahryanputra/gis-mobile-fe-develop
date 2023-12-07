using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SiTerangMobile.ViewModels
{
    internal class GarduViewModel
    {
        public IList<Gardu> Gardus { get; private set; }
        public GarduViewModel()
        {
            Gardus = new List<Gardu>();

            Gardus.Add(new Gardu
            {
                Name = "GI",
                Total = 120,
                Color = "#34c1cb"
            });
            Gardus.Add(new Gardu
            {
                Name = "GD",
                Total = 1532,
                Color = "#ffb43a"
            });
            Gardus.Add(new Gardu
            {
                Name = "GH",
                Total = 435,
                Color = "#34c1cb"
            });
        }
    }
}
