﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Action : MonoBehaviour
{
    public Action<int, int> sum;
    public Action<int, int> sum2;

    void Start()
    {
        // 従来の方法 : Action・変数宣言 作成してあるMethodを代入
        sum = CalculationSum;
        sum(1,2);

        // Lambda を利用した方法 : 変数にLambda式を利用してMethodを作成し、そのまま代入出来る
        // Method を別に用意しなくても記述できるという利点
        // Delegate = (引数, ...) => 返り値
        sum2 = (a, b) =>
        {
            var total = a +b;
            Debug.Log("Sum2 : " + total);
        };
    }
    void CalculationSum(int a, int b)
    {
        var total = a + b;
        Debug.Log("Sum : " + total);
    }
}

