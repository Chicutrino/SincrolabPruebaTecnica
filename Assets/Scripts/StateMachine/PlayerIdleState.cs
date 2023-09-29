using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    Rigidbody2D playerRb;
    public override void EnterState(PlayerStateManager character)
    {
        // Comienza animación de Idle
        Debug.Log("Entrando en Player Idle");
        playerRb = character.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState(PlayerStateManager character)
    {
        // Si el player se encuentra en el suelo y pulsa direccional => Walk
        if (Input.GetAxis("Horizontal") != 0)
            character.PlayerWalkState.EnterState(character);
        // Si el player se encuentra en el suelo y pulsa espacio => Jump
        if (Input.GetKeyDown(KeyCode.Space))
            character.PlayerJumpState.EnterState(character);
    }

    public override void OnCollisionEnter2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnTriggerStay2D(PlayerStateManager character, Collider2D collider)
    {
        // Si el enemigo entra en el trigger => Hit
        if (collider.tag == "Enemy")
            character.PlayerHitState.EnterState(character);
    }

    public override void OnCollisionStay2D(PlayerStateManager character, Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            
        }
    }
}
