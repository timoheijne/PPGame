using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    private int _currency;
    public int Currency
    {
        get { return _currency; }
        set
        {
            if (_currency == value) return;

            _currency = value;

            if (onCurrencyChange != null)
            {
                onCurrencyChange(_currency);
            }
        }
    }
    public delegate void OnCurrencyChange(int newValue);
    public event OnCurrencyChange onCurrencyChange;

    private void Start()
    {
        this.onCurrencyChange += CurrencyChangeHandler;
    }

    private void CurrencyChangeHandler(int newValue)
    {

    }
}
