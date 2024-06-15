namespace HomeWork3_16_2; 

public  class Block {
    public int Top {  get; set; }
    public int Bottom { get; set; }
    public int Left { get; set; }
    public int Right { get; set; }

    public override bool Equals(object other) {
        if (other is Block) {
            return Equals((Block)other);
        } else {
            return base.Equals(other);
        }
    }

    public bool Equals(Block other) {
        return
            Top == other.Top &&
            Bottom == other.Bottom &&
            Left == other.Left &&
            Right == other.Right;
    }

    public override string ToString() {
        return $"Top = {Top} Bottom = {Bottom} Left = {Left} Right = {Right}";
    }
}
