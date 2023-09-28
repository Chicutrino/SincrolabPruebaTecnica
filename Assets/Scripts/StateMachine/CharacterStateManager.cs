using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateManager : MonoBehaviour
{
    CharacterBaseState currentState;
    public CharacterHitState CharacterHitState = new CharacterHitState();
    public CharacterIdleState CharacterIdleState = new CharacterIdleState();
    public CharacterWalkState CharacterWalkState = new CharacterWalkState();
    public CharacterJumpState CharacterJumpState = new CharacterJumpState();

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
