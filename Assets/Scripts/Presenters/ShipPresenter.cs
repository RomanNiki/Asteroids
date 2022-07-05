using Models.Enemies;
using UnityEngine;

namespace Presenters
{
    public class ShipPresenter : Presenter
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out Presenter enemy))
            {
                if (enemy.Model is Enemy)
                {
                    DestroyCompose();
                }
            }
        }
    }
}