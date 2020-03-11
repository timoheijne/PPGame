using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    private static CurrencyManager _instance;
    private int _currency = 150;

    public int Currency
    {
        get { return _currency; }
        set
        {
            if (_currency == value) return;

            _currency = value;

            onCurrencyChange?.Invoke(_currency);
        }
    }

    public static bool SubstractCurrency(int cost)
    {
        if (_instance._currency - cost < 0) return false;

        _instance._currency -= cost;
        return true;
    }

    public delegate void OnCurrencyChange(int newValue);
    public event OnCurrencyChange onCurrencyChange;

    private void Start()
    {
        onCurrencyChange += CurrencyChangeHandler;
    }

    private void CurrencyChangeHandler(int newValue)
    {

    }
}
