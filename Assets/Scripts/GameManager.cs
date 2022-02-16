using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    bool bTimerStarted = false;
    float beginTime = 0;
    int Chapter = 1;

    TextMeshProUGUI textmesh;
    [SerializeField]
    Canvas CanvaUser;
    bool hasspoken = false;

    private void Start()
    {
        textmesh = CanvaUser.GetComponentInChildren<TextMeshProUGUI>();
    }
    void StartTime()
    {
        bTimerStarted = true;
        beginTime = Time.time;
    }
    float GetTime()
    {
        return Time.time - beginTime;
    }

    public IEnumerator Say(string phrase)
    {
        textmesh.text = "";
        for (int i = 0; i < phrase.Length; i++)
        {
            textmesh.text += phrase[i];
            //if (phrase[i]!=' ')
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(10f);
        textmesh.text = "";
    }
    /*private IEnumerator ClipCanvaUser()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
        }
    }*/
}