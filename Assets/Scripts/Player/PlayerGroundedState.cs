using UnityEngine;

public class PlayerGroundedState : PlayerBaseState
{
    public override void EnterState(Player player)
    {
        player.jumpsRemaining = player.data.maxJumps; // Reset jumps when grounded
        player.anim.SetBool("isGrounded", true); // Set grounded animation parameter
    }

    public override void UpdateState(Player player)
    {
        player.anim.SetFloat("HorizontalSpeed", Mathf.Abs(player.rBody.linearVelocityX));

        // TRANSITION LOGIC
        if (!player.CheckGrounded())
        {
            player.SwitchState(player.AirborneState);
        }
    }

    public override void FixedUpdateState(Player player)
    {
        // MOVEMENT LOGIC
        player.rBody.linearVelocity = new Vector2(player.moveInput.x * player.data.moveSpeed, player.rBody.linearVelocityY);
        player.FlipSprite(player.moveInput.x);
    }

    public override void OnJumpPressed(Player player)
    {
        // JUMPING LOGIC
        player.rBody.linearVelocity = new Vector2(player.rBody.linearVelocity.x, player.data.jumpForce);

        player.anim.SetTrigger("jump");

        AudioManager.Instance.PlayJump();

        player.jumpsRemaining--;

        player.SwitchState(player.AirborneState);
    }

    public override void ExitState(Player player) { }
}