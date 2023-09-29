using UnityEngine;

public class EnemyIdleState: EnemyBaseState
{
    public override void EnterState(EnemyStateManager character) 
    {
        // Comienza animaci�n de idle
        Debug.Log("Entrando en Idle");
    }

    public override void UpdateState(EnemyStateManager character) 
    {
        // Si la distancia del objetivo es menor o igual al rango => Walk
    }

    public override void OnCollisionEnter2D(EnemyStateManager character, Collision2D collision)
    {
        // Si colisiona con el objetivo entonces podr� atacar => Hit
    }

    public override void OnCollisionExit2D(EnemyStateManager character, Collision2D collision)
    {

    }
}
