using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/Super Gravity", fileName = "Effect_SuperGravity")]
public class Effect_SuperGravity : BaseEffect
{
    [SerializeField] float JumpHeightModifier = 0.5f;
    [SerializeField] float JumpVelocityModifier = 0.5f;
    [SerializeField] float FallForceModifier = 4f;

    public override float Effect_JumpHeight(float originalHeight)
    {
        return originalHeight * JumpHeightModifier;
    }

    public override float Effect_JumpVelocity(float originalVelocity)
    {
        return originalVelocity * JumpVelocityModifier;
    }

    public override float Effect_FallForce(float originalFallForce)
    {
        return originalFallForce * FallForceModifier;
    }
}
