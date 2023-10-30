using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{

    [SerializeField] private float rotation = 25f;


    private void Update()
    {
        transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
    }
}
