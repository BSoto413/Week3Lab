using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] public int cash = 0;

    void Start()
    {
        Cashflow(cash);
    }

    void Cashflow(int amount)
    {
        int hundredBills = amount / 100;
        amount %= 100;

        int fiftyBills = amount / 50;
        amount %= 50;

        int twentyBills = amount / 20;
        amount %= 20;

        int tenBills = amount / 10;
        amount %= 10;

        int fiveBills = amount / 5;
        amount %= 5;

        int oneBills = amount;

        Debug.Log("Amount to be paid: $" + cash);
        Debug.Log("Franklins: " + hundredBills);
        Debug.Log("Grants: " + fiftyBills);
        Debug.Log("Jacksons: " + twentyBills);
        Debug.Log("Hamiltons: " + tenBills);
        Debug.Log("Lincolns: " + fiveBills);
        Debug.Log("Washingtons: " + oneBills);
    }
}
