using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateManager : MonoBehaviour
{
    CharacterBaseState currentState;
    public EnemyHitState CharacterHitState = new EnemyHitState();
    public EnemyIdleState CharacterIdleState = new EnemyIdleState();
    public EnemyWalkState CharacterWalkState = new EnemyWalkState();
    public EnemyJumpState CharacterJumpState = new EnemyJumpState();

    private void Start()
    {
        currentState = CharacterIdleState;

        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(CharacterBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
