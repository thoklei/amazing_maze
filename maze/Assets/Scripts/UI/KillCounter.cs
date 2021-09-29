using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    [SerializeField] Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int kills = player.killCounter;
        GetComponent<TMPro.TextMeshProUGUI>().text = kills.ToString();
    }
}
