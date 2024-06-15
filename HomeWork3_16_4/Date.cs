namespace HomeWork3_16_4; 

public class Date {
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public static int operator -(Date d1, Date d2) {
        var x1 = new DateTime(d1.Year, d1.Month, d1.Day);
        var x2 = new DateTime(d2.Year, d2.Month, d2.Day);
        var x = x1.Subtract(x2);
        return Convert.ToInt32(x.TotalDays);
    }

    public static Date  operator +(Date d1, int days) {
        var x1 = new DateTime(d1.Year, d1.Month, d1.Day);
        var x2 = x1.AddDays(days);
        return new Date {
            Year = x2.Year,
            Day = x2.Day,
            Month = x2.Month
        };
    }

    public override string ToString() {
        return $"{Year}/{Month}/{Day}";
    }
}
