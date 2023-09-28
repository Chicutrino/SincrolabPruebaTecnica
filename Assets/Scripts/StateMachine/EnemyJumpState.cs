using UnityEngine;

public class EnemyJumpState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character)
    {
        // Animación de Salto
        // Impulso hacia arriba (Rigidbody2D)
    }

    public override void UpdateState(CharacterStateManager character)
    {
        // Cae tras llegar a una altura alcanzada por el impulso inicial
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {
        // Si colisiona con suelo => Walk
        // Si colisiona con enemigo => Hit
    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {

    }
}
