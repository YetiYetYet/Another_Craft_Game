using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodConsuption : MonoBehaviour
{
    public bool active = true;
    public float consuptionTime = 1;
    public int consuptionNumber = 10;
    [SerializeField] private IntVariable _food;
    private void Start()
    {
        StartCoroutine(IeFoodConsuption());
    }

    private IEnumerator IeFoodConsuption()
    {
        while (active)
        {
            yield return new WaitForSeconds(consuptionTime);
            _food.Value -= consuptionNumber;
        }
    }
}
