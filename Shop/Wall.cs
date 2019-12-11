using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleBuilderShop
{
    public interface IWall
    {
        int Thickness { get; set; }
        string Color { get; set; }

        int ReturnThickness();
        string ReturnColor();

        void SetThickness(int Thickness);
        void SetColor(string Color);
    }

    public class Wall : IWall
    {
        public int Thickness { get; set; }
        public string Color { get; set; }

        public int ReturnThickness()
        {
            return Thickness;
        }

        public string ReturnColor()
        {
            return Color;
        }

        public void SetThickness(int Thickness)
        {
            this.Thickness = Thickness;
        }

        public void SetColor(string Color)
        {
            this.Color = Color;
        }
    }
}
