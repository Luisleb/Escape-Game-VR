using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    bool bTimerStarted = false;
    float beginTime = 0;
    int Chapter = 1;

    TextMeshProUGUI textmesh;
    [SerializeField]
    Canvas CanvaUser;
    [SerializeField]
    GameObject boat;
    [SerializeField]
    GameObject XRGameObject;

    bool hasspoken = false;

    bool m_GameIsPaused =false;

    [SerializeField]
    private GameObject EndCanvas;

    [SerializeField]
    private GameObject lostCanvas;

    private void Start()
    {
        boat.SetActive(false);
        textmesh = CanvaUser.GetComponentInChildren<TextMeshProUGUI>();
    }
    public void StartTime()
    {
        bTimerStarted = true;
        beginTime = Time.time;
    }
    public float GetTime()
    {
        return Time.time - beginTime;
    }
    public void EndGame()
    {
        if (Time.time - beginTime == 10)
        {
            lostCanvas.SetActive(true);
            bTimerStarted = false;
            m_GameIsPaused = !m_GameIsPaused;
            Time.timeScale = m_GameIsPaused ? 0f : 1f;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public IEnumerator Say(string phrase, float TimeAfterDialog=5f)
    {
        textmesh.text = "";
        for (int i = 0; i < phrase.Length; i++)
        {
            textmesh.text += phrase[i];
            //if (phrase[i]!=' ')
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(TimeAfterDialog);
        textmesh.text = "";
    }
    public void BoatArriving()
    {
        boat.SetActive(true);
        boat.GetComponent<Animator>().SetBool("boatComing", true);
    }
    public void BoatLanding()
    {
        Debug.Log("Boat landing");
        //set parent XROrigin
        Transform[] enfants= XRGameObject.GetComponentsInChildren<Transform>();
        for (int i = 0;i < enfants.Length;i++)
        {
            //Parentage XROrigin
            if (enfants[i].name.Equals("XR Origin"))
            {
                enfants[i].SetParent(boat.transform);
                Debug.Log(enfants[i] + "is a XROrigin");
            }
            //Désactivation XRLocomotion
            else if (enfants[i].name.Equals("Locomotion System"))
            {
                enfants[i].gameObject.SetActive(false);
                Debug.Log(enfants[i] + "Locomotion System");
            }
        }
        boat.GetComponent<Animator>().SetBool("boatComing", false);
        StartCoroutine(EndScreen());
    }
    private IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(3);
        //appel ecran de fin
    }
}