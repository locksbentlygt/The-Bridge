using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBridges : MonoBehaviour
{
    public GameObject BridgePath;
    public GameObject Player;
   
    // Start is called before the first frame update
    void Start()
    {
     
       
        BridgePath.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void OnCollisionEnter(Collision collision)
    {
       
    }

}
