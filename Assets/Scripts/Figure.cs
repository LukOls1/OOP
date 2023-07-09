using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    private void Update()
    {
        DataManager.Instance.Horizontal = Input.GetAxis("Horizontal");
        DataManager.Instance.Vertical = Input.GetAxis("Vertical");
    }
    //ENCAPSULATION, ABSTRACTION
    protected virtual void MoveObject(Rigidbody rb, float horizontal, float vertical)
    {
        rb.AddForce(-horizontal * Vector3.forward, ForceMode.Acceleration);
        rb.AddForce(vertical * Vector3.right, ForceMode.Acceleration);
    }
    //ABSTRACTION
    protected void SetDefaultColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

}

