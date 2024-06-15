using HomeWork3_16_6;

var a = new Coordinate() {
    X = 5,
    Y = 10,
    Z = 4
};
var b = new Coordinate() {
    X = 3,
    Y = 5,
    Z = 3
};
var x = a + b;

Console.WriteLine($"{a} + {b} = {x}");