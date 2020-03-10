using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    private int _moneyz;

    void OnMoneyzChange(int amount)
    {
        _moneyz += amount;
    }
}
