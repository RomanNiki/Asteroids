using UnityEngine;

namespace Models.Weapon
{
    public class DefaultBullet : Bullet
    {
        private readonly Vector2 _direction;

        public DefaultBullet(Vector2 position, float lifeTime, float speed, Vector2 direction) : base(position, lifeTime, speed)
        {
            _direction = direction;
        }

        public override void Update(float deltaTime)
        {
            Vector2 nextPosition = Position + _direction * (Speed * deltaTime);

            MoveTo(nextPosition);

            base.Update(deltaTime);
        }
    }
}