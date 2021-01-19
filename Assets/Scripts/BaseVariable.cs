using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public abstract class BaseVariable<T, E> : ScriptableObject where E : BaseEvent<T>
{
    [SerializeField]
    private T _initialValue;
    [SerializeField]
    private T _value;
    [SerializeField] 
    private E _eventChanged;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            if (_eventChanged != null)
            {
                _eventChanged.Raise(_value);
            }
        }
    }

    void OnEnable()
    {
        _value = _initialValue;
    }
}
