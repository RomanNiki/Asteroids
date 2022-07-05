using Models.Enemies;
using UnityEngine;

namespace Presenters
{
    public class DefaultBulletPresenter : BulletPresenter
    {
        protected override void OnTriggerEnter2D(Collider2D col)
        {
            if (col.TryGetComponent<Presenter>(out var presenter))
            {
                if (presenter.Model is Enemy enemy)
                {
                    Kill?.Invoke(enemy, this);
                    DestroyCompose();
                }
            }
        }
    }
}