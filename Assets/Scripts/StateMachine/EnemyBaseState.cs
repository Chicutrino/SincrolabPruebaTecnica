using UnityEngine;

public abstract class EnemyBaseState{
    public abstract void EnterState(EnemyStateManager character);

    public abstract void UpdateState(EnemyStateManager character);

    public abstract void OnCollisionEnter2D(EnemyStateManager character, Collision2D collision);

    public abstract void OnCollisionExit2D(EnemyStateManager character, Collision2D collision);
}
