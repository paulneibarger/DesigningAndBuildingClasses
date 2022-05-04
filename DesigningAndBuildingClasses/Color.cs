using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    internal class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color()
        {
            this.red = 255;
            this.green = 255;
            this.blue = 255;
            this.alpha = 255;
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public byte GetRedValue()
        {
            return red;
        }

        public void SetRedValue(byte red)
        {
            this.red = red;
        }

        public byte GetGreenValue()
        {
            return green;
        }

        public void SetGreenValue(byte green)
        {
            this.green = green;
        }

        public byte GetBlueValue()
        {
            return blue;
        }

        public void SetBlueValue(byte blue)
        {
            this.blue = blue;
        }

        public byte GetAlphaValue()
        {
            return alpha;
        }

        public void SetAlphaValue(byte alpha)
        {
            this.alpha = alpha;
        }

        public string GetColors()
        {
            return $"RGB({this.red},{this.green},{this.blue})";
        }
    }
}
