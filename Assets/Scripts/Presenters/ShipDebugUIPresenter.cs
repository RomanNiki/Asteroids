using Models.Weapon;
using TMPro;
using UnityEngine;

namespace Presenters
{
    public class ShipDebugUIPresenter : MonoBehaviour
    {
        [SerializeField] private Startup _startup;

        [SerializeField] private TMP_Text _positionLabel;
        [SerializeField] private TMP_Text _rotationLabel;
        [SerializeField] private TMP_Text _speedLabel;
        [SerializeField] private TMP_Text _laserBulletsLabel;
        [SerializeField] private TMP_Text _laserRollbackLabel;

        private void OnEnable()
        {
            _startup.LaserGun.Shot += OnLaserGunShot;
            _startup.LaserGun.ShotAdd += OnLaserGunShotAdd;

            UpdateLasersCount();
        }

        private void OnDisable()
        {
            _startup.LaserGun.Shot -= OnLaserGunShot;
            _startup.LaserGun.ShotAdd -= OnLaserGunShotAdd;
        }
        
        private void Update()
        {
            _positionLabel.text = $"Position: {_startup.Ship.Position}";
            _rotationLabel.text = $"Rotation: {Mathf.RoundToInt(_startup.Ship.Rotation)}";
            _speedLabel.text = $"Speed: {Mathf.RoundToInt(_startup.Ship.Acceleration.magnitude * 10000)}";
            _laserRollbackLabel.text =
                $"To Rollback: {(_startup.LaserGunRollback.Cooldown - _startup.LaserGunRollback.AccumulatedTime):0.0}";
        }

        private void OnLaserGunShot(Bullet bullet)
        {
            UpdateLasersCount();
        }

        private void OnLaserGunShotAdd()
        {
            UpdateLasersCount();
        }

        private void UpdateLasersCount()
        {
            _laserBulletsLabel.text = $"Lasers: {_startup.LaserGun.Bullets} / {_startup.LaserGun.MaxBullets}";
        }
    }
}