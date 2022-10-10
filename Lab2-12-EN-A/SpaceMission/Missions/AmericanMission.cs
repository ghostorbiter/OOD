namespace SpaceMission.Missions
{
    public class AmericanMission
    {
        public Node Root { get; }

        public AmericanMission(Node root)
        {
            Root = root;
        }
    }

    public class Node
    {
        public Node Next { get; }

        public Planet Planet { get; }

        public double Distance { get; }

        public Node(Node next, Planet planet, double distance)
        {
            Next = next;
            Planet = planet;
            Distance = distance;
        }
    }
}
