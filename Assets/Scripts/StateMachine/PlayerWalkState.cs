using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    int speed = 10;
    int direction;
    CharacterSheet playerCharacterSheet;
    Rigidbody2D playerRb;

    public override void EnterState(PlayerStateManager character)
    {
        Debug.Log("Entrando en Player Walk");
        // Comienza animación de caminar
        // Player comienza a caminar hacia el objetivo
        var playerCharacterController = character.GetComponent<CharacterController>();
        playerCharacterSheet = playerCharacterController.characterSheet;
        playerRb = character.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState(PlayerStateManager character)
    {
        // Si pulsamos teclas de dirección player se mueve
        if (Input.GetAxisRaw("Horizontal") > 0)
            direction = 1;
        else if (Input.GetAxisRaw("Horizontal") < 0)
            direction = -1;
        else if (Input.GetAxisRaw("Horizontal") == 0)
            character.PlayerIdleState.EnterState(character);
        playerRb.MovePosition(character.transform.position + (character.transform.right * direction * playerCharacterSheet.Speed * speed * Time.deltaTime));
    }

    public override void OnCollisionEnter2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(PlayerStateManager character, Collision2D collision)
    {

    }

    public override void OnTriggerStay2D(PlayerStateManager character, Collider2D collider)
    {
        // Si un enemigo entra en el trigger => Hit
        if (collider.tag == "Enemy")
            character.PlayerHitState.EnterState(character);
    }

    public override void OnCollisionStay2D(PlayerStateManager character, Collision2D collision)
    {
        // Si el player se encuentra en el suelo y pulsa espacio => Jump
        if(collision.gameObject.tag == "Ground")
            if (Input.GetKeyDown(KeyCode.Space))
                character.PlayerJumpState.EnterState(character);
    }
}
