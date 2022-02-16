using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sandclock : MonoBehaviour
{
    [SerializeField]
    private Rigidbody hourglass;

    [SerializeField]
    private GameObject[] lights;

    [SerializeField]
    private XRGrabInteractable[] objects;

    // Start is called before the first frame update
    void Start()
    {
        hourglass.isKinematic = true;
        objects = FindObjectsOfType<XRGrabInteractable>();
        for (int j = 0; j < objects.Length; j++)
        {
            
            objects[j].enabled=false;

        }
            
    }

    // Update is called once per frame
    public void OnPlayerGrabbed(SelectEnterEventArgs args)
    {
        for (int j = 0; j < objects.Length; j++)
            objects[j].enabled = true;

        for (int i = 0; i < lights.Length; i++)
            lights[i].SetActive(true);
        hourglass.isKinematic = false;
        GameManager.Instance.StartTime();
    }

}
