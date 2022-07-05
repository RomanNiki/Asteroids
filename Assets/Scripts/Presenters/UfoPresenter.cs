using Models.Weapon;
using UnityEngine;

namespace Presenters
{
    public class UfoPresenter : Presenter
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent(out Presenter presenter))
            {
                if (presenter.Model is Bullet)
                {
                    DestroyCompose();
                }
            }
        }
    }
}