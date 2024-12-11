using System;
using UnityEngine;

public class Timer 
{
    private bool _isRunning = false;
    private float _elapsedTime = 0f;
    private int _timerTime = 0;
    private int _timeToWait;
    
    public event Action<int> OnSecondPassed;

    public Timer(int timeToWait)
    {
        _timeToWait = timeToWait;
    }
        
    public void StartClock()
    {
        _timerTime = _timeToWait;
        _elapsedTime = 0;
        _isRunning = true;
    }
        
    public void StopClock() => _isRunning = false;

    public void UpdateTimer()
    {
        if (!_isRunning) return;

        _elapsedTime += Time.unscaledDeltaTime;

        if (_elapsedTime >= 1f)
        {
            _elapsedTime -= 1f;
            _timerTime--;
            OnSecondPassed?.Invoke(_timerTime);
        }
    }
}
