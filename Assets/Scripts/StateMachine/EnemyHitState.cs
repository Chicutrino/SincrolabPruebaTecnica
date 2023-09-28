using UnityEngine;

public class EnemyHitState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character)
    {
        // Animación de golpear
        // Hace daño al objetivo
    }

    public override void UpdateState(CharacterStateManager character)
    {
        // Hace daño al objetivo cada x segundos
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {
        // Si el objetivo sale del rango => Walk
    }
}
