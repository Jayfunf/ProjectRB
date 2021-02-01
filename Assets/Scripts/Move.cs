using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Movement Speed Setting")]
    [SerializeField] [Range(0, 12)] private float movementSpeed = 4;
    [SerializeField] [Range(0, 5)] private float runMultiplier = 3f;

    [Header("Jumping Data Setting")]
    [SerializeField] [Range(0, 12)] private float JumpForce = 6f;

    /*[Header("Slope Setting")]
    [SerializeField] [Range(0, 60)] private float slopeForce = 45f;
    [SerializeField] [Range(0, 1.5f)] private float slopeRayDistanceMul = 0.8f;*/

    private void movement(){
        if (Input.GetKeyDown("W"))
        {

        }
        if (Input.GetKeyDown("a"))
        {

        }
        if (Input.GetKeyDown("s"))
        {

        }
        if (Input.GetKeyDown("d"))
        {

        }

    }
}
