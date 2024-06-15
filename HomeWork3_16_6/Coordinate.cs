namespace HomeWork3_16_6;

public struct Coordinate {
    public int X {  get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public static Coordinate operator + (Coordinate p1, Coordinate p2) {
        return new Coordinate() {
            X = p1.X + p2.X,
            Y = p1.Y + p2.Y,
            Z = p1.Z + p2.Z
        };
    }

    public override string ToString() {
        return $"[{X}; {Y}; {Z}]";
    }
}
