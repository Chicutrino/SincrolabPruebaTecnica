using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    EnemyBaseState currentState;
    public EnemyIdleState EnemyIdleState = new EnemyIdleState();
    public EnemyHitState EnemyHitState = new EnemyHitState();
    public EnemyWalkState EnemyWalkState = new EnemyWalkState();
    public EnemyJumpState EnemyJumpState = new EnemyJumpState();

    private void Start()
    {
        currentState = EnemyIdleState;

        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
