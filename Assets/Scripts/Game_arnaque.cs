using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class Game_arnaque : MonoBehaviour
{
    bool GameStarted = false;
    [SerializeField]
    GameObject Instructions;
    [SerializeField]
    GameObject PlayButton;
    [SerializeField]
    GameObject Key;

    Animator animMugs;

    private void Start()
    {
        Key.GetComponent<XRGrabInteractable>().enabled = false;
        Instructions.SetActive(false);
        gameObject.transform.parent.gameObject.SetActive(false);
    }
    IEnumerator LaunchGame()
    {
        animMugs = transform.parent.GetComponent<Animator>();
        PlayButton.SetActive(false);
        animMugs.SetBool("Playing", true);
        yield return new WaitForSeconds(2f);
        Instructions.SetActive(true);
        GameStarted = true;
    }
    public void LaunchGameCall()
    {
        StartCoroutine(LaunchGame());
    }

    public void choix1()
    {
        Debug.Log("Choix1");
        if (GameStarted)
            StartCoroutine(choose(0));
    }
    public void choix2()
    {
        Debug.Log("Choix2");
        if (GameStarted)
            StartCoroutine(choose(1));
    }
    public void choix3()
    {
        Debug.Log("Choix3");
        if (GameStarted)
            StartCoroutine(choose(2));
    }

    IEnumerator choose(int choice)
    {
        Instructions.SetActive(false);
        int randChoice = Random.Range(0,3);
        Key.transform.localPosition = new Vector3(0,0, -0.2f + randChoice * .2f); //z
        animMugs.SetBool("Playing", false);//lancer l'anim
        yield return new WaitForSeconds(0.5f);

        //Défaite, rejouer
        if (randChoice != choice)
        {
            PlayButton.GetComponentInChildren<TextMeshProUGUI>().text = "Rentente ta chance !\nCliquer pour rejouer !";
            PlayButton.SetActive(true);
        }
        //Victoire
        else
        {
            Instructions.GetComponent<TextMeshProUGUI>().text = "Bien joué !\nTu peux prendre la clef !";
            Instructions.SetActive(true);

            Key.GetComponent<XRGrabInteractable>().enabled = true;
            GameStarted = false;
        }
    }
}
