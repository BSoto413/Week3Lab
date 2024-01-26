using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] private int bookCost = 5;
    [SerializeField] private int copiesSold = 100;
    private float discount;
    private float finalCost;
    private float profit;
    private float storeCost;
    private float shipping;

    private void Start()
    {
        discount = bookCost  * 0.4f;
        storeCost = bookCost - discount;
        shipping = (copiesSold - 1) * 0.75f + 3;

        finalCost = (storeCost * copiesSold) + shipping;
        profit = (bookCost * copiesSold) - finalCost;

        Debug.Log("Final Cost: " + finalCost);
        Debug.Log("Profit: " + profit);
    }
}