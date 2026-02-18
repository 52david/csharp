using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Armor
{
    public class armorFart
    {
        public string DisplayName { get; set; }
        public int ArmorPower { get; set; }

        public EArmorPartName PartName { get; set; }
        public EArmorType ArmorType { get; set; }

        public int XLeft { get; set; }
        public int YTop { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public armorFart(string displayName, int armorPower, EArmorPartName partName, EArmorType armorType, int xLeft, int yTop, int width, int height)
        {
            DisplayName = displayName;
            ArmorPower = armorPower;
            PartName = partName;
            ArmorType = armorType;
            XLeft = xLeft;
            YTop = yTop;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return DisplayName;
        }
    }
    
}
