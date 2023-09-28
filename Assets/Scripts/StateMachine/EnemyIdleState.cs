using UnityEngine;

public class EnemyIdleState: CharacterBaseState
{
    public override void EnterState(CharacterStateManager character) 
    {
        Debug.Log("Entrando en Idle");
    }

    public override void UpdateState(CharacterStateManager character) 
    {
        // El personaje quedar� en este estado mientras no se mueva ni interact�e ninguna otra instancia
        // Si se mueve => Walk
        // Si salta => Jump
    }

    public override void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision)
    {
        // Si colisiona con el enemigo entonces podr� atacar => Hit
    }

    public override void OnCollisionExit2D(CharacterStateManager character, Collision2D collision)
    {

    }
}
