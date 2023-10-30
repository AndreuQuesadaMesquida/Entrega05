using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entrega05 : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float verticalSpeed = 5f;
    private string finish = "You Win!";

    private float verticalInput;

    void Update()
    {

        
        verticalInput = Input.GetAxis("Vertical");


        transform.Rotate(Vector3.left, verticalSpeed * Time.deltaTime * verticalInput);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z >= 250)
        {
            Debug.Log(finish);
        }


    }

}
