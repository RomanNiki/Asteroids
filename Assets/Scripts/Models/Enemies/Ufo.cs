using UnityEngine;

namespace Models.Enemies
{
    public class Ufo : Enemy
    {
        private readonly Transformable _target;
        
        public Ufo(Vector2 position, float rotation, float speed, Transformable target) : base(position, rotation, speed)
        {
            _target = target;
        }
        
        public override void Update(float deltaTime)
        {
            var nextPosition = Vector2.MoveTowards(Position, _target.Position, Speed * deltaTime);
            MoveTo(nextPosition);
            LookAt(_target.Position);
        }

        private void LookAt(Vector2 point)
        {
            Rotate(Vector2.SignedAngle(Quaternion.Euler(0, 0, Rotation) * Vector3.up, (Position - point)));
        }
    }
}