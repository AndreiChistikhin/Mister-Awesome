using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TimeSpeedUper : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    private CancellationTokenSource _cancellationTokenSource;
    private void Start()
    {
        Time.timeScale = 1;
        _audioSource.pitch = 1;
        _cancellationTokenSource = new CancellationTokenSource();
        StartSpeedUp(_cancellationTokenSource.Token);
    }

    private async Task StartSpeedUp(CancellationToken cancelationToken)
    {
        if (Time.timeScale >= 97)
            return;
        await Task.Delay(10000,cancelationToken);
        Time.timeScale *= 1.1f;
        _audioSource.pitch *= 1.01f;
        StartSpeedUp(cancelationToken);
    }

    private void OnDestroy()
    {
        _cancellationTokenSource.Cancel();
    }
}
