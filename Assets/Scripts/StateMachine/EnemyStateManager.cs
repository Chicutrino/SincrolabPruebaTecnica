using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    EnemyBaseState currentState;
    public EnemyHitState EnemyHitState = new EnemyHitState();
    public EnemyWalkState EnemyWalkState = new EnemyWalkState();
    public EnemyJumpState EnemyJumpState = new EnemyJumpState();

    private void Start()
    {
        // El enemigo no tiene Idle, empieza directamente caminando hacia el player
        currentState = EnemyWalkState;

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
