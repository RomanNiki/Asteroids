using UnityEngine;

namespace Models.Weapon
{
    public class Bullet : Transformable, IUpdatable
    {
        protected readonly float LifeTime;
        protected readonly float Speed;
        
        private float _accumulatedTime;
        
        public Bullet(Vector2 position, float lifeTime, float speed) : base(position, 0)
        {
            LifeTime = lifeTime;
            Speed = speed;
        }

        public virtual void Update(float deltaTime)
        {
            _accumulatedTime += Time.deltaTime;

            if(_accumulatedTime >= LifeTime)
            {
                Destroy();
            }
        }
    }
}