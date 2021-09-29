using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] Player player;

    //List<int> neededCoins = new List<int> { 20, 0, 5, 10, 15, 0 };
    //int neededCoin = checkpointManager.GetComponent<CheckpointManager>

    private int _neededCoins;
    private int _colectedCoins = 0;
    private int _playerCoins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _playerCoins = player.coinCounter;
        int coins = _playerCoins - _colectedCoins;
        GetComponent<TMPro.TextMeshProUGUI>().text = coins.ToString() + "/" +  _neededCoins;
    }

    public void SetNeededCoins(int neededCoins)
    {
        _neededCoins = neededCoins;
    }

    public void ResetCoinCounter()
    {
        //_colectedCoins += _playerCoins;
        player.ResetCoinCounter();
    }
}
