using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/Low Gravity", fileName = "Effect_LowGravity")]
public class Effect_LowGravity : BaseEffect
{
    [SerializeField] float JumpHeightModifier = 2f;
    [SerializeField] float JumpVelocityModifier = 2f;
    [SerializeField] float FallForceModifier = 0.25f;

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
