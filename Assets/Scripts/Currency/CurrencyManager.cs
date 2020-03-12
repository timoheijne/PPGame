using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    public static CurrencyManager _instance;
    public static CurrencyManager Instance { get { return _instance; } }

    private int _currency = 150;

    //Sets the currency after the player buys or earns currency
    public int Currency
    {
        get { return _currency; }
        set
        {
            if (_currency == value) return;

            _currency = value;

            OnCurrencyChange?.Invoke(_currency);
        }
    }

    //Checks if the player is able to buy a tower
    public bool SubstractCurrency(int _cost)
    {
        if (_instance._currency - _cost < 0) return false;

        _instance._currency += _cost;
        OnCurrencyChange?.Invoke(_currency);
        return true;
    }

    public Action<int> OnCurrencyChange;


    private void Start()
    {
        if(CurrencyManager.Instance == null)
        {
            _instance = this;
            OnCurrencyChange += CurrencyChangeHandler;
        } else
        {
            Destroy(this);
        }
        
    }

    public void CurrencyChangeHandler(int _newValue)
    {
        Debug.Log("change currency with: " + _newValue);

        if (_currency + _newValue < Currency)
        {
            Debug.Log("Substract: " + _newValue);
            SubstractCurrency(_newValue);
        }
    }
}