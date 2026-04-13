using UnityEngine;

public class PlayerCrouchState : PlayerBaseState
{
    public Collider2D collider;
    private Vector2 crouchingSize;
   
    public override void EnterState(Player player)
    {
        
    }

    public override void ExitState(Player player)
    {
        
    }

    public override void FixedUpdateState(Player player)
    {
        
    }

    public override void UpdateState(Player player)
    {
        
    }

    public void OnCrouchPressed(Player player)
    {
        _ = player.rBody.linearVelocity.x * 0.25;
        crouchingSize = new Vector2(1, 0.5f);

        Vector2 boxSize = collider.size
        Vector2 boxOffset = collider.offset;


    }
}
