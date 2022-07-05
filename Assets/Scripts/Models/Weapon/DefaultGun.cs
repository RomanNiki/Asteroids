using System;

namespace Models.Weapon
{
    public class DefaultGun
    {
        protected readonly Transformable Point;

        public DefaultGun(Transformable point)
        {
            Point = point;
        }

        public virtual bool CanShoot() => true;

        public event Action<Bullet> Shot;

        public void Shoot()
        {
            if (CanShoot() == false)
                throw new InvalidOperationException();

            Bullet bullet = GetBullet();
            Shot?.Invoke(bullet);
        }

        protected virtual Bullet GetBullet() => new DefaultBullet(Point.Position, Config.Bullets.DefaultBulletLifeTime, Config.Bullets.DefaultBulletSpeed, Point.Forward);
    }
}