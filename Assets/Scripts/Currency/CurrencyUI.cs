using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyUI : MonoBehaviour
{
    private Text _currencyTextField;

    void Start()
    {
        _currencyTextField = GameObject.Find("CurrencyText").GetComponent<Text>();
        AdjustUI(150);
    }

    public void AdjustUI(int _newValue)
    {
        _currencyTextField.text = "Florins: " + _newValue;
    }
}
