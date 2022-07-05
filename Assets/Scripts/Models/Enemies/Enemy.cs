using UnityEngine;

namespace Models.Enemies
{
    public abstract class Enemy : Transformable, IUpdatable
    {
        protected readonly float Speed;

        public Enemy(Vector2 position, float rotation, float speed) : base(position, rotation)
        {
            Speed = speed;
        }

        public abstract void Update(float deltaTime);
    }
}