using UnityEngine;

public class EnemyWalkState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character) 
    {
        // Enemigo comienza a caminar hacia el objetivo
    }

    public override void UpdateState(CharacterStateManager character) 
    {
        // Camina hacia el objetivo
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {
        // Si colisiona con Player => Hit
        // Si colisiona con Obstáculo => Jump
    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {
        // Si el Player sale de la colisión => Walk
    }
}
