using System;
using System.Collections.Generic;
using System.Text;

namespace shop_builder
{
    public interface IRoof
    {
        int Height { get; set; }

        int ReturnHeight();

        void SetHeight(int Height);
    }

    public class Roof : IRoof
    {
        public int Height { get; set; }

        public int ReturnHeight()
        {
            return Height;
        }

        public void SetHeight(int Height)
        {
            this.Height = Height;
        }
    }
}