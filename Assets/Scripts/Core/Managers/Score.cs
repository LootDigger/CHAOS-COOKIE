using System;
using UnityEngine;

public class Score : IModel<int>
{
    private int _scoreValue;
    public event Action<int> OnModelChangedEvent;
      
    public int Value { get => _scoreValue;
        set
        {
            _scoreValue = value;
            OnModelChangedEvent?.Invoke(_scoreValue);
        }
    }
}


public interface IModel<T> where T: struct
{
    event Action<int> OnModelChangedEvent;
    T Value { get; set; }
}
