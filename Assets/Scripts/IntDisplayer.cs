using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntDisplayer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private IntVariable _variable;

    public void Start()
    {
        UpdateDisplayer(_variable.Value);
    }

    public void UpdateDisplayer(int value)
    {
        _text.SetText(value.ToString());
    }
}
