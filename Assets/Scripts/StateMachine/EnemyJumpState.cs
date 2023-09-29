using UnityEngine;

public class EnemyJumpState: EnemyBaseState
{
    CharacterSheet enemyCharacterSheet;
    Rigidbody2D enemyRb;
    Transform playerTransform;
    float distance;
    int sign;
    public override void EnterState(EnemyStateManager character)
    {
        Debug.Log("Entrando en Enemy Jump");
        // Animación de Salto
        // Impulso hacia arriba (Rigidbody2D)
        enemyCharacterSheet = character.GetComponent<CharacterSheet>();
        enemyRb = character.GetComponent<Rigidbody2D>();
        enemyRb.AddForce(Vector2.up * enemyCharacterSheet.Strength);
    }

    public override void UpdateState(EnemyStateManager character)
    {
        // Animación de caída tras alcanzar una altura máxima
    }

    public override void OnCollisionEnter2D(EnemyStateManager character, Collision2D collision)
    {
        // Si colisiona con suelo => Walk
        if (collision.gameObject.tag == "Ground")
            character.EnemyWalkState.EnterState(character);
        // Si colisiona con player => Hit
        if (collision.gameObject.tag == "Player")
            character.EnemyHitState.EnterState(character);
    }

    public override void OnCollisionExit2D(EnemyStateManager character, Collision2D collision)
    {

    }
}
