using HomeWork3_16_4;

var date1 = new Date() {
    Month = 3,
    Day = 12,
    Year = 1945
};
var date2 = new Date() {
    Month = 3,
    Day = 3,
    Year = 1945
};

var diff = date1 - date2;

Date date3 = date2 + 5; 

Console.WriteLine($"{date1} - {date2} = {diff} days");
Console.WriteLine($"{date2} + 5 days = {date3}");