using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStatistics : MonoBehaviour
{
    public int money;
    public int income;
    public float infamy;
    int[] provinceIncome;

    private void Start()
    {
        money = 100;
        infamy = 0f;
        income = 0;
        provinceIncome = new int[0];
    }
}
