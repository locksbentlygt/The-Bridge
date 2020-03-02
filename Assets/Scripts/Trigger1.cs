using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject[] BridgePath2;

    // Start is called before the first frame update
    void Start()
    {
        BridgePath2 = GameObject.FindGameObjectsWithTag("BridgePath2");
        for (int i = 0; i < BridgePath2.Length; i++)
        {
            BridgePath2[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigered Rocks");
        for (int p = 0; p < BridgePath2.Length; p++)
        {
            BridgePath2[p].SetActive(true);
            Debug.Log("Bridge 1 is Up");
        }
    }
}
