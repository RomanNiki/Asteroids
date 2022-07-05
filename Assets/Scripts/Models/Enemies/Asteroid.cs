using UnityEngine;

namespace Models.Enemies
{
    public class Asteroid : Enemy
    {
        private readonly Vector2 _direction;
        
        public Asteroid(Vector2 position, float rotation, float speed, Vector2 direction) : base(position, rotation, speed)
        {
            _direction = direction;
        }

        public override void Update(float deltaTime)
        {
            MoveTo(Position + _direction * (deltaTime * Speed));
            if (Position.x is > -1 or < 2 || Position.y is >-1 or < 2)
                return;
            
            Destroy();
        }
        
        public PartOfAsteroid CreatePart()
        {
            return new PartOfAsteroid(Position, 0f,  Speed / 2, Random.insideUnitCircle.normalized);
        }
    }
}