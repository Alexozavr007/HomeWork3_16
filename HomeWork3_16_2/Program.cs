using HomeWork3_16_2;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var block1 = new Block {
    Top = 12,
    Left = 13,
    Right = 14,
    Bottom = 15
};
var block2 = new Block() {
    Top = 12,
    Left = 13,
    Right = 14,
    Bottom = 15
};
var block3 = new Block() {
    Top = 23,
    Left = 24,
    Right = 25,
    Bottom = 26,
};
Console.WriteLine($"Блок1: {block1.ToString()}");

Console.WriteLine($"Блок2: {block2.ToString()}");

Console.WriteLine($"Блок3: {block3.ToString()}");

Console.WriteLine($"Результат порівнювання блоку1 і блоку2 = {block1.Equals(block2)}");

Console.WriteLine($"Результат порівнювання блоку2 і блоку3 = {block2.Equals(block3)}");

