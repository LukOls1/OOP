using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Figure //INHERITANCE
{
    private void Update()
    {
        if (DataManager.Instance.ActualRb == GetComponent<Rigidbody>())
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
        rb.transform.Translate(vertical, horizontal, 0, Space.Self);
    }
}
