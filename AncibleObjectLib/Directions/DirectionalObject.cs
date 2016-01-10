namespace AncibleObjectLib.Directions
{
    public class DirectionalObject
    {
        public DirectionalObject(Position north, Position south, Position east, Position west)
        {
            North = north;
            South = south;
            East = east;
            West = west;
        }

        public Position North { get; set; }
        public Position South { get; set; }
        public Position East { get; set; }
        public Position West { get; set; }
    }
}