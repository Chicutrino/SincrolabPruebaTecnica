using UnityEngine;

public class EnemyIdleState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character) 
    {
        Debug.Log("Entrando en Idle");
    }

    public override void UpdateState(CharacterStateManager character) 
    {
        // Si la distancia del objetivo es menor o igual al rango => Walk
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {
        // Si colisiona con el objetivo entonces podrá atacar => Hit
    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {

    }
}
