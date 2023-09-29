using UnityEngine;

public class EnemyWalkState: EnemyBaseState
{
    CharacterSheet enemyCharacterSheet;
    Rigidbody2D enemyRb;
    Transform playerTransform;
    float distance;
    int sign;

    public override void EnterState(EnemyStateManager character) 
    {
        Debug.Log("Entrando en Enemy Walk");
        // Inicializamos variables
        enemyCharacterSheet = character.GetComponent<CharacterSheet>();
        enemyRb = character.GetComponent<Rigidbody2D>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        distance = Vector2.Distance(character.transform.position, playerTransform.position);
    }

    public override void UpdateState(EnemyStateManager character) 
    {
        // Enemigo comienza a caminar hacia el objetivo
        if (character.transform.position.x < playerTransform.position.x)
            sign = 1;
        else if (character.transform.position.x >= playerTransform.position.x)
            sign = -1;
        enemyRb.MovePosition(character.transform.position + (character.transform.right * sign * enemyCharacterSheet.Speed * Time.deltaTime));
    }

    public override void OnCollisionEnter2D(EnemyStateManager character, Collision2D collision)
    {
        // Si colisiona con Player => Hit
        if (collision.gameObject.tag == "Player")
            character.EnemyHitState.EnterState(character);
        // Si colisiona con Obstáculo => Jump
        if (collision.gameObject.tag == "Obstacle")
            character.EnemyJumpState.EnterState(character);
    }

    public override void OnCollisionExit2D(EnemyStateManager character, Collision2D collision)
    {

    }
}
