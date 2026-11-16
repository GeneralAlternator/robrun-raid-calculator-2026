using System;
using System.Threading;
using System.Threading.Tasks;

namespace ROBRUNRaidCalculator;

public class LaundryTimer
{
    public event EventHandler TimerCompleted;

    private CancellationTokenSource _cancellationTokenSource;

    /// <summary>
    /// Converts dirty cash into a laundering cycle duration.
    /// The rate is 450 units of dirty cash per 30 seconds.
    /// </summary>
    public TimeSpan CalculateTime(decimal dirtyCash)
    {
        double secondsPerUnit = 30.0 / 450.0;
        double seconds = Math.Max(0.0, (double)dirtyCash * secondsPerUnit);
        return TimeSpan.FromSeconds(seconds);
    }

    /// <summary>
    /// Starts the laundering timer for the given amount of dirty cash.
    /// </summary>
    public void StartTimer(decimal amount)
    {
        StopTimer();

        TimeSpan duration = CalculateTime(amount);
        _cancellationTokenSource = new CancellationTokenSource();

        Task.Run(async () =>
        {
            try
            {
                await Task.Delay(duration, _cancellationTokenSource.Token);
                TimerCompleted?.Invoke(this, EventArgs.Empty);
            }
            catch (OperationCanceledException)
            {
                // Timer was stopped by the user.
            }
        });
    }

    /// <summary>
    /// Stops the running laundering timer.
    /// </summary>
    public void StopTimer()
    {
        _cancellationTokenSource?.Cancel();
        _cancellationTokenSource?.Dispose();
        _cancellationTokenSource = null;
    }
}
