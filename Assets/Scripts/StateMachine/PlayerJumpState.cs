using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    CharacterSheet playerCharacterSheet;
    Rigidbody2D playerRb;
    int jumpForce = 100;

    public override void EnterState(PlayerStateManager character)
    {
        Debug.Log("Entrando en Player Jump");
        // Animación de Salto
        // Impulso hacia arriba (Rigidbody2D)
        playerRb = character.gameObject.GetComponent<Rigidbody2D>();
        playerCharacterSheet = character.GetComponent<CharacterController>().characterSheet;
        playerRb.AddForce(Vector2.up * playerCharacterSheet.Strength * jumpForce);
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
