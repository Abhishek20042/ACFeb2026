struct Banner
{
    //init-only property, can only be set in initializer
    public float Width { get; init; }

    public float Height { get; init; }

    public double Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"{Width} x {Height}"; //interpolated string
    }
}