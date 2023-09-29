using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    CharacterSheet playerCharacterSheet;
    Rigidbody2D playerRb;

    public override void EnterState(PlayerStateManager character)
    {
        // Animación de Salto
        // Impulso hacia arriba (Rigidbody2D)
        playerRb = character.GetComponent<Rigidbody2D>();
        playerRb.AddForce(Vector2.up * playerCharacterSheet.Strength);
    }

    public override void UpdateState(PlayerStateManager character)
    {
        // Cae tras llegar a una altura alcanzada por el impulso inicial
    }

    public override void OnCollisionEnter2D(PlayerStateManager character, Collision2D collision)
    {
        // Si colisiona con suelo => Idle
        if (collision.gameObject.tag == "Ground")
            character.PlayerIdleState.EnterState(character);
        // Si colisiona con player => Hit
        if (collision.gameObject.tag == "Enemy")
            character.PlayerHitState.EnterState(character);
    }

    public override void OnCollisionExit2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnTriggerStay2D(PlayerStateManager character, Collider2D collider)
    {

    }

    public override void OnCollisionStay2D(PlayerStateManager character, Collision2D collision)
    {

    }
}
