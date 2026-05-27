namespace Finance;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
public class MaxDurationAttribute(int value = 5) : Attribute
{
    public int Limit { get; set; } = value;
}