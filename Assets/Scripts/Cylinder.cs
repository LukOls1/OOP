using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Figure //INHERITANCE
{
    private float rotationSpeed = 5f;
    private void Update()
    {
        if (DataManager.Instance.ActualRb == gameObject.GetComponent<Rigidbody>())
        {
            MoveObject(DataManager.Instance.ActualRb, DataManager.Instance.Horizontal, DataManager.Instance.Vertical);
        }
        else
        {
            SetDefaultColor();
        }
    }
    //POLIMORPHISM
    protected override void MoveObject(Rigidbody rb, float horizontal, float vertical)
    {
        transform.Rotate(Vector3.right, horizontal * rotationSpeed);
    }
}
