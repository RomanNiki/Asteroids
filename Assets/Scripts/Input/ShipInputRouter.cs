using Models;
using Models.Weapon;
using UnityEngine.InputSystem;

namespace Input
{
    public class ShipInputRouter : IUpdatable
    {
        private readonly ShipInput _input;
        private readonly Ship _ship;

        private readonly DefaultGun _primaryWeapon;
        private readonly DefaultGun _secondaryWeapon;

        public ShipInputRouter(Ship ship, DefaultGun primaryWeapon, DefaultGun secondaryWeapon)
        {
            _ship = ship;
            _primaryWeapon = primaryWeapon;
            _secondaryWeapon = secondaryWeapon;
            _input = new ShipInput();
        }

        public void OnEnable()
        {
            _input.Ship.PrimiryShoot.performed += PrimaryWeaponShoot;
            _input.Ship.SecondaryShoot.performed += SecondaryWeaponShoot;
            _input.Enable();
        }

        public void OnDisable()
        {
            _input.Disable();
            _input.Ship.PrimiryShoot.performed -= PrimaryWeaponShoot;
            _input.Ship.SecondaryShoot.performed -= SecondaryWeaponShoot;
        }

        public void Update(float deltaTime)
        {
            if (MoveForwardPerformed())
            {
                _ship.Accelerate(deltaTime);
            }
            else
            {
                _ship.SlowDown(deltaTime);
            }
            
            TryRotate(deltaTime);
        }
        
        private bool MoveForwardPerformed() => _input.Ship.MoveForward.phase == InputActionPhase.Performed;
        
        
        private void PrimaryWeaponShoot(InputAction.CallbackContext context)
        {
            TryShoot(_primaryWeapon);
        }

        private void SecondaryWeaponShoot(InputAction.CallbackContext context)
        {
            TryShoot(_secondaryWeapon);
        }
        
        private void TryShoot(DefaultGun gun)
        {
            if (gun.CanShoot())
                gun.Shoot();
        }
        
        private void TryRotate(float delta)
        {
            float direction = _input.Ship.Rotate.ReadValue<float>();

            if(direction != 0)
                _ship.Rotate(direction, delta);
        }
    }
}