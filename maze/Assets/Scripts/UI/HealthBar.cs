using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Image healthBarImage;

    void Update()
    {
        // Update value of Healthbar
        // var currentHealth = player.GetHealth();
        // var healthPercentage = currentHealth / 100f;
        // healthBarImage.fillAmount = healthPercentage;

        this.gameObject.transform.rotation = Quaternion.identity;

    }
}
