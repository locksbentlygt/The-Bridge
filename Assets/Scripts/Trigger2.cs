using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public GameObject[] BridgePath1;

    // Start is called before the first frame update
    void Start()
    {
        BridgePath1 = GameObject.FindGameObjectsWithTag("BeridgePath1");
        for (int i = 0; i < BridgePath1.Length; i++)
        {
            BridgePath1[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigered");
        for (int p = 0; p < BridgePath1.Length; p++)
        {
            BridgePath1[p].SetActive(true);
            Debug.Log("Bridge 2 is Up");
        }
    }
}
