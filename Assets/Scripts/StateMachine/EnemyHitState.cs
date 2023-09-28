using UnityEngine;

public class EnemyHitState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character)
    {
        // Animaci�n de golpear
        // Hace da�o al objetivo
    }

    public override void UpdateState(CharacterStateManager character)
    {
        // Hace da�o al objetivo cada x segundos
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {
        // Si el objetivo sale del rango => Walk
    }
}
