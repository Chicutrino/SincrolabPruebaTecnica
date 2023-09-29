using UnityEngine;

public class PlayerHitState : PlayerBaseState
{
    CharacterSheet enemyCharacterSheet;

    public override void EnterState(PlayerStateManager character)
    {
        // Activa animación de preparación para el golpe
    }

    public override void UpdateState(PlayerStateManager character)
    {
        
    }

    public override void OnCollisionEnter2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(PlayerStateManager character, Collision2D collision)
    {
        // Si el objetivo sale del rango => Walk
    }

    public override void OnTriggerStay2D(PlayerStateManager character, Collider2D collider)
    {
        if (collider.tag == "Enemy")
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                enemyCharacterSheet = collider.GetComponent<CharacterSheet>();
                character.GetComponent<CharacterController>().TakeDamage(enemyCharacterSheet.Strength);
            }
    }

    public override void OnCollisionStay2D(PlayerStateManager character, Collision2D collision)
    {

    }
}
