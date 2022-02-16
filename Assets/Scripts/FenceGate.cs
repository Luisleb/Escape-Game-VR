using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FenceGate : MonoBehaviour
{
    bool alreadyOpened = false;
    private void Start()
    {
        //StartCoroutine(rotationGate());
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.tag.Equals("Clef") && alreadyOpened==false)
            OpeningGate(args.interactableObject.transform);

    }
    private void OpeningGate(Transform clef)
    {
        Debug.Log(clef.name);
        alreadyOpened = true;
        transform.parent.GetComponent<Animator>().SetBool("IsOpen", true);
        StartCoroutine(GameManager.Instance.Say("Il faut maintenant trouver un moyen de partir d'ici !"));
    }
}
