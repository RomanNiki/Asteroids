using Models;
using Models.Enemies;
using TMPro;
using UnityEngine;

namespace Presenters
{
    public class ScorePresenter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreLabel;
        private Score _score;
        public int Score => _score.Value;

        private void Awake()
        {
            _score = new Score();
            UpdateScoreLabel();
        }
        
        public void OnKill(Enemy enemy, BulletPresenter bulletPresenter)
        {
            bulletPresenter.Kill -= OnKill;
            _score.OnKill(enemy);
            UpdateScoreLabel();
        }

        private void UpdateScoreLabel()
        {
            _scoreLabel.text = $"Score : {Score}";
        }
    }
}