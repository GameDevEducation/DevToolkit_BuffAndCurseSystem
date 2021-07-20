using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEffect : ScriptableObject
{
    [SerializeField] protected float Duration = 0f;

    public bool IsActive => DurationRemaining > 0f;

    float DurationRemaining = 0f;

    public void EnableEffect()
    {
        DurationRemaining = Duration;
    }

    public void TickEffect()
    {
        // tick the effect
        if (DurationRemaining > 0)
            DurationRemaining -= Time.deltaTime;
    }

    public virtual float Effect_JumpHeight(float originalHeight)
    {
        return originalHeight;
    }

    public virtual float Effect_JumpVelocity(float originalVelocity)
    {
        return originalVelocity;
    }

    public virtual float Effect_FallForce(float originalFallForce)
    {
        return originalFallForce;
    }

    public virtual float Effect_GroundSpeed(float originalGroundSpeed)
    {
        return originalGroundSpeed;
    }

    public virtual float Effect_InAirSpeed(float originalInAirSpeed)
    {
        return originalInAirSpeed;
    }

    public virtual Vector2 Effect_CameraInput(Vector2 originalCameraInput)
    {
        return originalCameraInput;
    }    
}
