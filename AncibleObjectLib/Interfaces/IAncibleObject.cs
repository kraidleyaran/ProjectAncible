namespace AncibleObjectLib.Interfaces
{
    public interface IAncibleObject
    {
        string Name { get; set; }
        ObjectType ObjectType { get; }
    }
}