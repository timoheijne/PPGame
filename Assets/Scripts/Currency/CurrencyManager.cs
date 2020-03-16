using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager _instance;
    public static CurrencyManager Instance { get { return _instance; } }

    [Serializable]
    public class IntEvent : UnityEvent<int> { }

    public IntEvent OnChange;

    private int _currency = 150;

    public int Currency
    {
        get { return _currency; }
        set
        {
            if (_currency == value) return;

            _currency = value;
            OnCurrencyChange?.Invoke(_currency);
            OnChange?.Invoke(Currency);
        }
    }

    public Action<int> OnCurrencyChange;


    private void Start()
    {
        if(CurrencyManager.Instance == null)
        {
            _instance = this;
        } else
        {
            Destroy(this);
        }
    }

    public bool ChangeAmountBy(int _newValue)
    {
        if (_currency + _newValue < 0) return false;

        _currency += _newValue;
        return true;
    }
}