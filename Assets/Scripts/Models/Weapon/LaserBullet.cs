using UnityEngine;

namespace Models.Weapon
{
    public class LaserBullet : Bullet
    {
        public LaserBullet(Vector2 position, float lifeTime, Vector2 direction) : base(position, lifeTime, 0f)
        {
            Rotate(Vector2.SignedAngle(Vector2.up, direction));
        }
    }
}