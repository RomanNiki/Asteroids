using System;
using UnityEngine;

namespace Models
{
    public class Ship : Transformable, IUpdatable
    {
        public Ship(Vector2 position, float rotation) : base(position, rotation)
        {
        }
        
        public Vector2 Acceleration { get; private set; }

        public void Accelerate(float deltaTime)
        {
            Acceleration += Forward * (Config.Ship.UnitsPerSecond * deltaTime);
            Acceleration = Vector2.ClampMagnitude(Acceleration, Config.Ship.MaxSpeed);
        }

        public void SlowDown(float deltaTime)
        {
            Acceleration -= Acceleration * (deltaTime / Config.Ship.SecondsToStop);
        }

        public void Rotate(float direction, float deltaTime)
        {
            if (direction == 0)
                throw new InvalidOperationException(nameof(direction));

            direction = direction > 0 ? 1 : -1;
            
            Rotate(direction * (Config.Ship.DegreesPerSecond * deltaTime));
        }

        public void Update(float deltaTime)
        {
            Move(Acceleration);
        }
        
        private void Move(Vector2 delta)
        {
            var nextPosition = Position + delta;
            nextPosition.y = Mathf.Repeat(nextPosition.y, 1);
            nextPosition.x = Mathf.Repeat(nextPosition.x, 1);

            MoveTo(nextPosition);
        }
    }
}
