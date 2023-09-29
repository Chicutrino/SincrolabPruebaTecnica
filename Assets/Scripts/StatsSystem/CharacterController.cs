using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public CharacterSheet characterSheet;

    public int maxHealth;
    public int currentHealth { get; private set; }

    [SerializeField] private CircleCollider2D collider;

    private void Awake()
    {
        maxHealth = characterSheet.Health;
        currentHealth = maxHealth;
        GetComponent<SpriteRenderer>().sprite = characterSheet.CharacterSprite;
        collider.radius = characterSheet.Range;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(characterSheet.Strength);
        }
    }

    public void TakeDamage(int strength)
    {
        var damage = strength;
        if (damage <= 0)
            damage = 1;

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

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
