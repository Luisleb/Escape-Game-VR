using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interaction_PNJ : MonoBehaviour
{
    TextMeshProUGUI textmesh;
    [SerializeField]
    Canvas CanvaUser;
    bool hasspoken = false;
    [SerializeField]
    GameObject game;

    public void LaunchDialogue()
    {
        if (!hasspoken)
        {
            textmesh = CanvaUser.GetComponentInChildren<TextMeshProUGUI>();
            hasspoken = true;
            StartCoroutine(GameManager.Instance.Say("Bonjour visiteur, voulez-vous jouer à un jeu ?", 5f));
            game.SetActive(true);
        }
    }
}
