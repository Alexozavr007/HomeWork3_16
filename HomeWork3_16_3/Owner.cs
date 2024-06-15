namespace HomeWork3_16_3; 
public  class Owner {
    public string Name { get; set; }
    public bool IsHuman { get; set; }

    public override string ToString() {
        return $"{Name} (is human - {IsHuman})";
    }
}