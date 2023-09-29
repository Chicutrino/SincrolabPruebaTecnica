using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager: MonoBehaviour
{
    PlayerBaseState currentState;
    public PlayerIdleState PlayerIdleState = new PlayerIdleState();
    public PlayerHitState PlayerHitState = new PlayerHitState();
    public PlayerWalkState PlayerWalkState = new PlayerWalkState();
    public PlayerJumpState PlayerJumpState = new PlayerJumpState();

    private void Start()
    {
        currentState = PlayerIdleState;

        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
