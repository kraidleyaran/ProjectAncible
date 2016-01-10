using AncibleObjectLib.Directions;

namespace ProjectAncible.Actions
{
    public class MoveAction : IAction
    {
        public ActionType ActionType { get {return ActionType.Move;} }
        public FacingDirection Direction { get; set; }
    }
}