using System;
using System.Collections.Generic;
using System.Text;

namespace SiTerangMobile.ViewModels
{
    internal class PelangganViewModel
    {
        public IList<Pelanggan> Pelanggans { get; private set; }
        public PelangganViewModel()
        {
            Pelanggans = new List<Pelanggan>();

            Pelanggans.Add(new Pelanggan
            {
                Type = "PELANGGAN",
                Total = 16789
            });
            Pelanggans.Add(new Pelanggan
            {
                Type = "PELANGGAN MENUNGGAK",
                Total = 3621
            });
            Pelanggans.Add(new Pelanggan
            {
                Type = "PELANGGAN P2TL",
                Total = 245
            });
        }
    }
}
