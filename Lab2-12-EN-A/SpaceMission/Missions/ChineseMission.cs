namespace SpaceMission.Missions
{
    public class ChineseMission
    {
        public double[,] Distances { get; }

        public Planet[] Route { get; }

        public ChineseMission(double[,] distances, Planet[] route)
        {
            Distances = distances;
            Route = route;
        }
    }
}
