using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuting_rope : MonoBehaviour
{
    [SerializeField]
    private GameObject[] barrels; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "sword")
        {
            for(int i = 0; i < barrels.Length; i++)
                barrels[i].GetComponent<Rigidbody>().isKinematic = false;
            gameObject.SetActive(false);
        }
    }
}
