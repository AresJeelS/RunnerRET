using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] private int _value;
    [SerializeField] private DeformationType _deformationType;
    [SerializeField] GateAppearaence _gateAppearaence;

    private void OnValidate()
    {
        _gateAppearaence.UpdateVisual(_deformationType, _value);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playermodifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playermodifier)
        {
            if (_deformationType == DeformationType.Widht)
            {

                playermodifier.AddWidth(_value);
            }
            else if (_deformationType == DeformationType.Height)
            {
                playermodifier.AddHeight(_value);
            }
            Destroy(gameObject);
        }
    }
}
