using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance;
    private Rigidbody actualRb;
    private float vertical;
    private float horizontal;
    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataManager>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<DataManager>();
                    singletonObject.name = "DataManager (Singleton)";
                }
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public Rigidbody ActualRb
    {
        get { return actualRb; }
        set { actualRb = value; }
    }
    public float Vertical
    {
        get { return vertical; }
        set { vertical = value; }
    }
    public float Horizontal
    {
        get { return horizontal; }
        set { horizontal = value; }
    }
}