using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] Player player;

    private int _neededCoins;
    private int _collectedCoins = 0;
    private int _playerCoins;


    // Update is called once per frame
    void Update()
    {
        _playerCoins = player.coinCounter;
        int coins = _playerCoins - _collectedCoins;
        GetComponent<TMPro.TextMeshProUGUI>().text = coins.ToString() + "/" +  _neededCoins;
    }

    public void SetNeededCoins(int neededCoins)
    {
        _neededCoins = neededCoins;
    }

    public void ResetCoinCounter()
    {
        _collectedCoins += _neededCoins;
    }
}
