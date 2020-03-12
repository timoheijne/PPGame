using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMoney : MonoBehaviour
{
    private int worth = 50;
    private int cost = -50;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            CurrencyManager.Instance.ChangeAmountBy(50);
            //_currencyChange(worth);
            Debug.Log(CurrencyManager.Instance.Currency);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            CurrencyManager.Instance.ChangeAmountBy(-50);
            //_currencyChange(cost);
            Debug.Log(CurrencyManager.Instance.Currency);
        }
    }
}
