using System;
using System.Collections.Generic;
using System.Diagnostics;
using SpaceMission.Missions;

namespace SpaceMission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var americanMission = PrepareAmericanMission(new List<(Planet, double)>()
            {
                (Planet.Mercury, 120),
                (Planet.Venus, 105),
                (Planet.Earth, 80),
                (Planet.Mars, 95),
                (Planet.Jupiter, 125),
                (Planet.Saturn, 90),
                (Planet.Uranus, 130),
                (Planet.Neptune, 70)
            });

            var chineseMission = new ChineseMission(
                new double[,]
                {
                    { 000, 150, 230, 300, 355, 400, 490, 550 },
                    { 150, 000, 150, 220, 300, 420, 500, 630 },
                    { 230, 150, 000, 100, 160, 200, 300, 390 },
                    { 300, 220, 100, 000, 120, 200, 320, 400 },
                    { 355, 300, 160, 120, 000, 100, 180, 250 },
                    { 400, 420, 200, 200, 100, 000, 130, 200 },
                    { 490, 500, 300, 320, 180, 130, 000, 110 },
                    { 550, 630, 390, 400, 250, 200, 110, 000 }
                },
                new Planet[]
                {
                    Planet.Earth,
                    Planet.Mars,
                    Planet.Saturn,
                    Planet.Uranus,
                    Planet.Venus,
                    Planet.Mercury,
                    Planet.Earth
                }
            );

            Debug.Assert(Algorithms.TotalDistance(/* argument */) == 815, "Wrong value - assert 1"); // americanMission
            Debug.Assert(Algorithms.TotalDistance(/* argument */) == 1310, "Wrong value - assert 2"); // chineseMission

            Debug.Assert(Algorithms.TotalDistance(Algorithms.MovingAverage(/* argument */, 5)) == 410, "Wrong value - assert 3"); // americanMission
            Debug.Assert(Algorithms.TotalDistance(Algorithms.MovingAverage(/* argument */, 4)) == 730, "Wrong value - assert 4"); // chineseMission
        }

        private static AmericanMission PrepareAmericanMission(List<(Planet, double)> planets)
        {
            Node root = null;
            for (int i = planets.Count - 1; i >= 0; i--)
            {
                var node = new Node(root, planets[i].Item1, planets[i].Item2);
                root = node;
            }

            return new AmericanMission(root);
        }
    }
}
