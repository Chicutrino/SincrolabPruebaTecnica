using UnityEngine;

public abstract class PlayerBaseState
{
    public abstract void EnterState(PlayerStateManager character);

    public abstract void UpdateState(PlayerStateManager character);

    public abstract void OnCollisionEnter2D(PlayerStateManager character, Collision2D collision);

    public abstract void OnCollisionExit2D(PlayerStateManager character, Collision2D collision);

    public abstract void OnTriggerStay2D(PlayerStateManager character, Collider2D collider);
    public abstract void OnCollisionStay2D(PlayerStateManager character, Collision2D collision);
}
