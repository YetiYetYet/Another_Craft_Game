using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseListener<T, E, UE> : MonoBehaviour, IListener<T> where E : BaseEvent<T> where UE : UnityEvent<T>
{
    [SerializeField] private E _event;
    [SerializeField] private UnityEvent<T> _response;

    public void OnEnable()
    {
        _event.Register(this);
    }

    public void OnDisable()
    {
        _event.UnRegister(this);
    }

    public void Raise(T value)
    {
        if (_response != null)
        {
            _response.Invoke(value);
        }
    }
}
