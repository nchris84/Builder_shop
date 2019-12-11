using System;

namespace ExampleBuilderShop
{
    class Program
    {
        static void Main(string[] args)
        {
            IShopBuilder shopbuilder = new BigShopTesco();
            ShopDirector shopdirector = new ShopDirector(shopbuilder);
            shopdirector.buildShop();

            Shop shop = shopdirector.getShop();
            Console.WriteLine("Shop color: " + shop.GetWall().ReturnColor() +
               "\nThickness of the shop wall: " + shop.GetWall().ReturnThickness() +
               "\nThe height of the roof: " + shop.GetRoof().ReturnHeight() +
               "\nNumber of tiles: " + shop.GetFloor().ReturnNumberOfTiles() +
               "\nThe length of the floor: " + shop.GetFloor().ReturnLenght() +
               "\nThe type of tile size: " + shop.GetFloor().ReturnTypeGreatnessTiles());

            Console.ReadKey();
        }
    }
}
