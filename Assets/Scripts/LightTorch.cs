using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTorch : MonoBehaviour
{
    [SerializeField] GameObject flames;
    [SerializeField] public bool lighted;
    private void Start()
    {
        GameManager.Instance.BoatArriving();
        if (!lighted)
            flames.SetActive(false);
        else
            flames.SetActive(true);
    }
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other);
        if (other.gameObject.name.Equals("Fire"))
        {
            if (other.gameObject.GetComponent<LightTorch>().lighted)
            {
                flames.SetActive(true);
                lighted = true;

                if (transform.name.Equals("fireplace"))
                {
                    //faire arriver le bateau
                    GameManager.Instance.BoatArriving();
                    StartCoroutine(GameManager.Instance.Say("Bateau en vue !"));
                }
            }
        }
    }

}
