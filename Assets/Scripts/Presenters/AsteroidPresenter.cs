using Models.Enemies;
using Models.Weapon;
using UnityEngine;

namespace Presenters
{
    public class AsteroidPresenter : Presenter
    {
        private PresenterFactory _factory;
        public new Asteroid Model => base.Model as Asteroid;

        public void Init(PresenterFactory factory)
        {
            _factory = factory;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent<Presenter>(out var bullet))
            {
                if (bullet.Model is Bullet)
                {
                    if (bullet.Model is LaserBullet)
                    {
                        DestroyCompose();
                        return;
                    }

                    _factory.CreateParts(this);
                    DestroyCompose();
                }
            }
        }
    }
}