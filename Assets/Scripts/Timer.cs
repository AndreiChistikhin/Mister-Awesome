using System.Threading.Tasks;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timer;
    private int _fullSecondsInGame;
    private string _minutesInGame;
    private string _secondsInGame;

    private void Start()
    {
        UpdateTimer();
    }

    private async void UpdateTimer()
    {
        await Task.Delay(1000);
        _fullSecondsInGame++;
        _minutesInGame = (_fullSecondsInGame / 60).ToString("00");
        _secondsInGame = (_fullSecondsInGame % 60).ToString("00");
        _timer.text = $"{_minutesInGame}:{_secondsInGame}";
        UpdateTimer();
    }
}
