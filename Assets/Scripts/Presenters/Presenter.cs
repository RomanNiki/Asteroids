using Models;
using UnityEngine;

namespace Presenters
{
    public class Presenter : MonoBehaviour
    {
        private Camera _camera;
        public Transformable Model { get; private set; }
        private IUpdatable _updatable;

        public void Init(Transformable model, Camera camera)
        {
            Model = model;
            _camera = camera;

            if (Model is IUpdatable updatable)
            {
                _updatable = updatable;
            }

            enabled = true;
            OnMoved();
            OnRotated();
        }

        private void Update()
        {
            _updatable?.Update(Time.deltaTime);
        }

        private void OnEnable()
        {
            Model.Moved += OnMoved;
            Model.Rotated += OnRotated;
            Model.Destroying += OnDestroying;
        }

        private void OnDisable()
        {
            Model.Moved -= OnMoved;
            Model.Rotated -= OnRotated;
            Model.Destroying -= OnDestroying;
        }

        private void OnMoved()
        {
            transform.position = _camera.ViewportToWorldPoint(GetViewportPosition(Model));
        }

        private static Vector3 GetViewportPosition(Transformable model)
        {
            return new Vector3(model.Position.x, model.Position.y, 1);
        }

        private void OnRotated()
        {
            transform.rotation = Quaternion.Euler(0, 0, Model.Rotation);
        }

        private void OnDestroying()
        {
            Destroy(gameObject);
        }
        
        protected void DestroyCompose()
        {
            Model.Destroy();
        }
    }
}