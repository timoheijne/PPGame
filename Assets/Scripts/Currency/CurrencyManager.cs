using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyManager : MonoBehaviour
{
    private Text _currencyText;
    private int _currency = 150;

    public int Currency
    {
        get { return _currency; }
        set
        {
            if (_currency == value) return;

            _currency = value;

            onCurrencyChange?.Invoke(_currency);
            //_currencyText.text = "Florins: " + _currency;
        }
    }

    public delegate void OnCurrencyChange(int newValue);
    public event OnCurrencyChange onCurrencyChange;

    private void Start()
    {
        _currencyText = GameObject.Find("CurrencyText").GetComponent<Text>();
        _currencyText.text = "Florins: " + _currency.ToString();

        onCurrencyChange += CurrencyChangeHandler;
    }

    private void CurrencyChangeHandler(int newValue)
    {

    }
}
