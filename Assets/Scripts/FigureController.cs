using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectedFigure();
        }
    }
    void SelectedFigure()
    {
        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform.tag == "Figure")
        {
            DataManager.Instance.ActualRb = hitInfo.transform.gameObject.GetComponent<Rigidbody>();
            hitInfo.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

}
