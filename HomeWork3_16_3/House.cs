namespace HomeWork3_16_3;

public class House : ICloneable {
    public int ballsCount;
    public string ballsType;
    public int Size { get; set; }
    public Owner? Owner {  get; set; }
    
    public object Clone() {
        return this.MemberwiseClone();
    }

    public House DeepClone(){
        return new House {
            ballsCount = ballsCount,
            ballsType = ballsType,
            Size = Size,
            Owner = (Owner == null) ? null : new Owner {
                IsHuman = Owner.IsHuman,
                Name = Owner.Name
            }
        };
    }

    public override string ToString() {
        return $"balls: {ballsCount} ({ballsType}), size: {Size}, owner: {Owner?.ToString() ?? "-"}";
    }

}
