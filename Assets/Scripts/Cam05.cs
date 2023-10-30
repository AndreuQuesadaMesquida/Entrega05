using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam05 : MonoBehaviour
{

    [SerializeField] private GameObject cameraS;

    [SerializeField] private Vector3 offset = new Vector3(0, 0, 0);

    private void LateUpdate()
    {
        cameraS.transform.position = transform.position + offset;
    }

}
