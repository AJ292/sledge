using System.Collections.Generic;
using System.Linq;
using Sledge.DataStructures.GameData;
using Sledge.DataStructures.MapObjects;
using Sledge.Editor.Actions;

namespace Sledge.Editor.Problems
{
    public class PointEntityWithChildren : IProblemCheck
    {
        public IEnumerable<Problem> Check(Map map)
        {
            foreach (var entity in map.WorldSpawn
                .Find(x => x is Entity).OfType<Entity>()
                .Where(x => x.GameData != null)
                .Where(x => x.GameData.ClassType != ClassType.Solid && x.Children.Any()))
            {
                yield return new Problem(GetType(), new[] { entity }, Fix, "Point entity has children", "A point entity with children was found. A point entity cannot have any contents. Fixing the issue will move the children outside of the entity's group.");
            }
        }

        public IAction Fix(Problem problem)
        {
            throw new System.NotImplementedException();
        }
    }
}