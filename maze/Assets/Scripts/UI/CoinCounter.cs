using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int coins = player.GetComponent<Player>().coinCounter;
        int neededCoin = 0;
        GetComponent<TMPro.TextMeshProUGUI>().text = coins.ToString() + "/" +  neededCoin;
    }
}
