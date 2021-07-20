using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectableObject : MonoBehaviour
{
    List<BaseEffect> ActiveEffects = new List<BaseEffect>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // tick all active effects - cleanup any that are finished
        for(int index = ActiveEffects.Count - 1; index >= 0; --index)
        {
            ActiveEffects[index].TickEffect();

            // effect finished?
            if (!ActiveEffects[index].IsActive)
                ActiveEffects.RemoveAt(index);
        }
    }

    public void ApplyEffect(BaseEffect effectTemplate)
    {
        // create a new instance of the effect
        var newEffect = ScriptableObject.Instantiate(effectTemplate);

        // make the effect active
        newEffect.EnableEffect();
        ActiveEffects.Add(newEffect);
    }

    public float Effect_JumpHeight(float originalHeight)
    {
        float workingHeight = originalHeight;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingHeight = ActiveEffects[index].Effect_JumpHeight(workingHeight);
        }

        return workingHeight;
    }

    public float Effect_JumpVelocity(float originalJumpVelocity)
    {
        float workingJumpVelocity = originalJumpVelocity;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingJumpVelocity = ActiveEffects[index].Effect_JumpVelocity(workingJumpVelocity);
        }

        return workingJumpVelocity;
    }

    public float Effect_FallForce(float originalFallForce)
    {
        float workingFallForce = originalFallForce;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingFallForce = ActiveEffects[index].Effect_FallForce(workingFallForce);
        }

        return workingFallForce;
    }

    public float Effect_GroundSpeed(float originalGroundSpeed)
    {
        float workingGroundSpeed = originalGroundSpeed;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingGroundSpeed = ActiveEffects[index].Effect_GroundSpeed(workingGroundSpeed);
        }

        return workingGroundSpeed;
    }

    public float Effect_InAirSpeed(float originalInAirSpeed)
    {
        float workingInAirSpeed = originalInAirSpeed;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingInAirSpeed = ActiveEffects[index].Effect_InAirSpeed(workingInAirSpeed);
        }

        return workingInAirSpeed;
    }

    public Vector2 Effect_CameraInput(Vector2 originalCameraInput)
    {
        Vector2 workingCameraInput = originalCameraInput;

        // apply any active effects
        for (int index = 0; index < ActiveEffects.Count; ++index)
        {
            if (!ActiveEffects[index].IsActive)
                continue;

            workingCameraInput = ActiveEffects[index].Effect_CameraInput(workingCameraInput);
        }

        return workingCameraInput;
    }
}
