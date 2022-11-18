using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    int currentGold = 0;
    [SerializeField] TextMeshProUGUI goldDisplay;

    private void Start()
    {
        goldDisplay.text = "Gold: " + currentGold;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            currentGold++;
            Destroy(other.gameObject);
            UpdateGold();
        }
    }

    private void UpdateGold()
    {
        goldDisplay.text = "Gold: " + currentGold;
    }
}
