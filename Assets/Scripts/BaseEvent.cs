using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEvent<T> : ScriptableObject
{
    private List<IListener<T>> _listeners = new List<IListener<T>>();

    public void Register(IListener<T> listener)
    {
        _listeners.Add(listener);
    }

    public void UnRegister(IListener<T> listener)
    {
        _listeners.Remove(listener);
    }
    public void Raise(T value)
    {
        for (int i = _listeners.Count - 1; i >= 0; i--)
        {
            _listeners[i].Raise(value);
        }
    }
}
