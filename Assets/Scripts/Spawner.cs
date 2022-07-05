using Models;
using Models.Enemies;
using Presenters;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _secondsPerIndex;
    [SerializeField] private int _ufoChance;
    [SerializeField] private PresenterFactory _factory;
    [SerializeField] private Startup _startup;

    private int _index;
    
    private void Update()
    {
        var newIndex = (int)(Time.time / _secondsPerIndex);

        if (newIndex > _index)
        {
            _index = newIndex;
            SpawnExample();
        }
    }

    private void SpawnExample()
    {
        float chance = Random.Range(0, 100);

        if (chance < _ufoChance)
        {
            _factory.CreateNlo(new Ufo(GetRandomPositionOutsideScreen(), 0, Config.Enemies.UfoSpeed, _startup.Ship));
        }
        else
        {
            Vector2 position = GetRandomPositionOutsideScreen();
            Vector2 direction = GetDirectionThroughtScreen(position);

            _factory.CreateAsteroid(new Asteroid(position, 0f, Config.Enemies.AsteroidSpeed, direction));
        }
    }

    private Vector2 GetRandomPositionOutsideScreen()
    {
        return Random.insideUnitCircle.normalized + new Vector2(0.5F, 0.5F);
    }

    private static Vector2 GetDirectionThroughtScreen(Vector2 position)
    {
        return (new Vector2(Random.value, Random.value) - position).normalized;
    }
}