using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Presenters
{
    public class EndGamePresenter : MonoBehaviour
    {
        [SerializeField] private ScorePresenter _scorePresenter;
        [SerializeField] private TMP_Text _scoreLabel;
        [SerializeField] private Button _restartButton;

        private void OnEnable()
        {
            _restartButton.onClick.AddListener(OnRestartButtonClick);
            _scoreLabel.text = $"Your Score : {_scorePresenter.Score}";
        }

        private void OnDisable()
        {
            _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        }

        private static void OnRestartButtonClick()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}