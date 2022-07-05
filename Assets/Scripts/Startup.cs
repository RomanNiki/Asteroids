using Input;
using Models;
using Models.Weapon;
using Presenters;
using UnityEngine;

public class Startup : MonoBehaviour
{
    [SerializeField] private ShipPresenter _shipPresenter;
    [SerializeField] private Camera _camera;
    [SerializeField] private PresenterFactory _factory;
    [SerializeField] private CanvasGroup _scorePresenter;
    [SerializeField] private ShipDebugUIPresenter _shipDebugUIPresenter;
    
    [SerializeField] private EndGamePresenter _gameOverWindow;

    private Ship _shipModel;
    private ShipInputRouter _shipInputRouter;
    private DefaultGun _baseGun;
    private LaserGun _laserGun;
    private LaserGunRollback _laserGunRollback;
    public Ship Ship => _shipModel;
    public LaserGun LaserGun => _laserGun;
    public LaserGunRollback LaserGunRollback => _laserGunRollback;
    
    private void Awake()
    {
        _shipModel = new Ship(new Vector2(0.5f, 0.5f), 0f);
        _baseGun = new DefaultGun(_shipModel);
        _laserGun = new LaserGun(_shipModel, Config.Bullets.LaserBulletCount);
        _shipInputRouter = new ShipInputRouter(_shipModel, _baseGun, _laserGun);
        _shipPresenter.Init(_shipModel, _camera);
        _laserGunRollback = new LaserGunRollback(_laserGun, Config.Bullets.LaserCooldown);
    }

    private void OnEnable()
    {
        _shipModel.Destroying += OnShipDestroy;
        _baseGun.Shot += OnShot;
        _laserGun.Shot += OnShot;
        _shipInputRouter.OnEnable();
    }

    private void OnDisable()
    {
        _shipModel.Destroying -= OnShipDestroy;
        _baseGun.Shot -= OnShot;
        _laserGun.Shot -= OnShot;
        _shipInputRouter.OnDisable();
    }

    private void Update()
    {
        var time = Time.deltaTime;
        _shipInputRouter.Update(time);
        _laserGunRollback.Update(time);
    }

    private void OnShot(Bullet bullet)
    {
        _factory.CreateBullet(bullet);
    }
    

    private void OnShipDestroy()
    {
        _scorePresenter.alpha = 0f;
        _shipDebugUIPresenter.enabled = false;
        _gameOverWindow.gameObject.SetActive(true);
        OnDisable();
    }
}