using UnityEngine;

public abstract class CharacterBaseState
{
    public abstract void EnterState(CharacterStateManager character);

    public abstract void UpdateState(CharacterStateManager character);

    public abstract void OnCollisionEnter2D(CharacterStateManager character, Collision2D collision);

    public abstract void OnCollisionExit2D(CharacterStateManager character, Collision2D collision);
}
