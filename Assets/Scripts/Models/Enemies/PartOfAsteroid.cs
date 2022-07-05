using Vector2 = UnityEngine.Vector2;

namespace Models.Enemies
{
    public class PartOfAsteroid : Asteroid
    {
        public PartOfAsteroid(Vector2 position, float rotation, float speed, Vector2 direction) : base(position, rotation, speed, direction)
        {
        }
    }
}