using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class gravity : MonoBehaviour
{

    [SerializeField]
    private Rigidbody[] barrels;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < barrels.Length; i++)
        {
            barrels[i].isKinematic = true;
            barrels[i].useGravity = false;
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnReleaseGrabbed(SelectExitEventArgs args)
    {
        for (int i = 0; i < barrels.Length; i++)
        {
            barrels[i].isKinematic = false;
            barrels[i].useGravity = true;
        }

    }
}
