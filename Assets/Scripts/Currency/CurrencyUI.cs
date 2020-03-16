using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CurrencyUI : MonoBehaviour
{
    public static CurrencyUI _instance;
    public static CurrencyUI Instance { get { return _instance; } }

    private Text _currencyTextField;

    void Start()
    {
        if (CurrencyUI.Instance == null) {
            _instance = this;
        } else {
            Destroy(this);
        }

        _currencyTextField = GameObject.Find("CurrencyText").GetComponent<Text>();
        AdjustUI(150);
    }
    
    public void AdjustUI(int _newValue)
    {
        _currencyTextField.text = "Florins: " + _newValue;
    }
}
