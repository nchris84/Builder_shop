using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleBuilderShop
{
    public interface IFloor
    {
        int Lenght { get; set; }
        int NumberOfTiles { get; set; }
        string TypeGreatnessTiles { get; set; }

        int ReturnLenght();
        int ReturnNumberOfTiles();
        string ReturnTypeGreatnessTiles();

        void SetLenght(int Lenght);
        void SetNumberOfTiles(int NumberOfTiles);
        void SetTypeGreatnessTiles(string TypeGreatnessTiles);
    }

    public class Floor : IFloor
    {
        public int Lenght { get; set; }
        public int NumberOfTiles { get; set; }
        public string TypeGreatnessTiles { get; set; }

        public int ReturnLenght()
        {
            return Lenght;
        }
        public int ReturnNumberOfTiles()
        {
            return NumberOfTiles;
        }
        public string ReturnTypeGreatnessTiles()
        {
            return TypeGreatnessTiles;
        }

        public void SetLenght(int Lenght)
        {
            this.Lenght = Lenght;
        }
        public void SetNumberOfTiles(int NumberOfTiles)
        {
            this.NumberOfTiles = NumberOfTiles;
        }
        public void SetTypeGreatnessTiles(string TypeGreatnessTiles)
        {
            this.TypeGreatnessTiles = TypeGreatnessTiles;
        }
    }
}
