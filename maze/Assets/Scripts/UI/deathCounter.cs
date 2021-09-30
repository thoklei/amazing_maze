using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathCounter : MonoBehaviour
{

    [SerializeField] Player player;

    // Update is called once per frame
    void Update()
    {
        int deaths = player.deathCounter;
        GetComponent<TMPro.TextMeshProUGUI>().text = deaths.ToString();
    }
}
