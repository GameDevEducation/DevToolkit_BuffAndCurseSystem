using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTrigger : MonoBehaviour
{
    [SerializeField] BaseEffect Effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // apply the effect if supported
        var effectableObject = other.GetComponent<EffectableObject>();
        if (effectableObject != null)
        {
            effectableObject.ApplyEffect(Effect);
        }
    }
}
