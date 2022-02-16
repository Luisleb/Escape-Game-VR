using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sandclock : MonoBehaviour
{
    [SerializeField]
    private Rigidbody hourglass;


    // Start is called before the first frame update
    void Start()
    {
        hourglass.isKinematic = true;

    }

    // Update is called once per frame
    public void OnPlayerGrabbed(SelectEnterEventArgs args)
    {


        hourglass.isKinematic = false;
    }

}
