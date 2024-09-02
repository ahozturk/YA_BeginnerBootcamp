using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1.Models
{
    public class Siparis
    {
        public string BurgerTipi { get; set; }
        public string Soslar { get; set; }
        public string Adres { get; set; }
        public string ZamanDamgasi { get; set; }
        public string OdemeTipi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $"Burger Tipi: {BurgerTipi}\n\nSoslar:\n{Soslar}\nAdres: {Adres}\n\nFiyat: {Fiyat}\n\nÖdeme Tipi: {OdemeTipi}\n\nTarih: {ZamanDamgasi}";
        }
    }
}
