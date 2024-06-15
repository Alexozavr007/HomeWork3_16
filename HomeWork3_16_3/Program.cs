using HomeWork3_16_3;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var house = new House() {
    ballsCount = 777,
    ballsType = "Basketball",
    Size = 100,
    Owner = new Owner() {
        IsHuman = true,
        Name = "Jack"
    }
};

var house2 = (House)house.Clone();
var house3 = house.DeepClone();

Console.WriteLine($"Оригінальний об'єкт (до змін)\r\n{house.ToString()}\r\n");
Console.WriteLine($"Клон (поверхневий спосіб)\r\n{house2.ToString()}\r\n");
Console.WriteLine($"Клон (Deep спосіб)\r\n{house3.ToString()}\r\n");

Console.WriteLine($"{new String('=', 60)}\r\n");


house.ballsCount = 123;
house.ballsType = "Voleyball";
house.Owner.Name = "Apple Inc.";
house.Size = 32;
house.Owner.IsHuman = false;

Console.WriteLine($"Оригінальний об'єкт (після змін)\r\n{house.ToString()}\r\n");
Console.WriteLine($"Клон (поверхневий спосіб)\r\n{house2.ToString()}\r\n");
Console.WriteLine($"Клон (Deep спосіб)\r\n{house3.ToString()}\r\n");


