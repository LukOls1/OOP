using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Figure //INHERITANCE
{
    private void Update()
    {
        if(DataManager.Instance.ActualRb == gameObject.GetComponent<Rigidbody>())
        {
            MoveObject(DataManager.Instance.ActualRb, DataManager.Instance.Horizontal, DataManager.Instance.Vertical);
        }
        else
        {
            SetDefaultColor();
        }
    }
}
