using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/Inverted Controls", fileName = "Effect_InvertedControls")]
public class Effect_InvertedControls : BaseEffect
{
    public override Vector2 Effect_CameraInput(Vector2 originalCameraInput)
    {
        return originalCameraInput * -1f;
    }
}
