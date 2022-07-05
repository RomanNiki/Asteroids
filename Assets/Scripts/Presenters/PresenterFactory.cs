using Models;
using Models.Enemies;
using Models.Weapon;
using UnityEngine;

namespace Presenters
{
    public class PresenterFactory : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private ScorePresenter _scorePresenter;
        [SerializeField] private Presenter _asteroidPrefab;
        [SerializeField] private Presenter _asteroidPartPrefab;
        [SerializeField] private Presenter _ufoPrefab;
        [SerializeField] private Presenter _defaultBulletPrefab;
        [SerializeField] private Presenter _laserBulletPrefab;
        [SerializeField] private int _asteroidPartsCount = 4;

        public void CreateBullet(Bullet bullet)
        {
            var presenter =
                CreatePresenter(bullet is DefaultBullet ? _defaultBulletPrefab : _laserBulletPrefab, bullet) as
                    BulletPresenter;
            presenter.Kill += _scorePresenter.OnKill;
        }
        
        public void CreateParts(AsteroidPresenter asteroid)
        {
            for (int i = 0; i < _asteroidPartsCount; i++)
            {
                CreatePresenter(_asteroidPartPrefab, asteroid.Model.CreatePart());
            }
        }

        public void CreateNlo(Ufo nlo)
        {
            CreatePresenter(_ufoPrefab, nlo);
        }

        public void CreateAsteroid(Asteroid asteroid)
        {
            var presenter = CreatePresenter(_asteroidPrefab, asteroid) as AsteroidPresenter;
            presenter.Init(this);
        }

        private Presenter CreatePresenter(Presenter template, Transformable model)
        {
            Presenter presenter = Instantiate(template);
            presenter.Init(model, _camera);

            return presenter;
        }
    }
}