using UnityEngine;

public class EnemyHitState : EnemyBaseState
{
    GameObject player;
    CharacterController enemyController;
    CharacterController playerController;
    float cooldown = 60;

    public override void EnterState(EnemyStateManager character)
    {
        Debug.Log("Entrando en Enemy Hit");
        // Animación de golpear
        // Hace daño al objetivo        
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<CharacterController>();
        playerController.TakeDamage(character.GetComponent<CharacterController>().characterSheet.Strength);
    }

    public override void UpdateState(EnemyStateManager character)
    {
        // Hace daño al objetivo cada x segundos
        float timer = 0;
        timer += Time.deltaTime;

        if(timer >= cooldown)
        {
            playerController.TakeDamage(character.GetComponent<CharacterController>().characterSheet.Strength);
            timer = 0;
        }
    }

    public override void OnCollisionEnter2D(EnemyStateManager character, Collision2D collision)
    {

    }

    public override void OnCollisionExit2D(EnemyStateManager character, Collision2D collision)
    {
        // Si el objetivo sale del rango => Walk
        if(collision.gameObject.tag == "Player")
        {
            character.EnemyWalkState.EnterState(character);
        }
    }
}
