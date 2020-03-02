using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public GameObject[] BridgePath3;

    // Start is called before the first frame update
    void Start()
    {
        BridgePath3 = GameObject.FindGameObjectsWithTag("BridgePath3");
        for (int i = 0; i < BridgePath3.Length; i++)
        {
            BridgePath3[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigered Rocks");
        for (int p = 0; p < BridgePath3.Length; p++)
        {
            BridgePath3[p].SetActive(true);
            Debug.Log("Bridge 3 is Up");
        }
    }
}
