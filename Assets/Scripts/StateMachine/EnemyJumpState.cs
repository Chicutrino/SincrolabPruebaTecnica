using UnityEngine;

public class EnemyJumpState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character)
    {
        // Animación de Salto
    }

    public override void UpdateState(CharacterStateManager character)
    {
        // Si cae al suelo
            // Si camina => Walk
            // Si no camina => Idle
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {
        // Si colisiona con enemigo => Hit
    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {

    }
}
