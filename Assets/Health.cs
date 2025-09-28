using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;

    public TextMeshProUGUI HealthText;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        //CurrentHealth = CurrentHealth - Damage

        if(CurrentHealth < 0)
        {
            CurrentHealth = 0;
        }
    }
    public void Healing(float heal)
    {
        CurrentHealth += heal;

        if(CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }

    public void Update()
    {
        HealthText.text = "HP: " + CurrentHealth.ToString("F1");
    }
}
