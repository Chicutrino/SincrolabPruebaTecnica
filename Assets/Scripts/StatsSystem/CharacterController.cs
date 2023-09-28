using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth { get; private set; }

    [SerializeField] private CharacterSheet characterSheet;

    private void Awake()
    {
        maxHealth = int.Parse(characterSheet.Health.ToString());
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(int.Parse(characterSheet.Damage.ToString()), int.Parse(characterSheet.Strength.ToString()));
        }
    }

    public void TakeDamage(int damage, int strength)
    {
        var totalDamage = damage + strength;
        currentHealth -= totalDamage;
        Debug.Log(transform.name + " takes " + totalDamage + " damage.");

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    public virtual void Die() // TODO: Crear este estado en la máquina de estados
    {
        // Muerte horripilante
        // Este método podrá ser sobrescrito
        Debug.Log(transform.name + " died.");
    }
}
