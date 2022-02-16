using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouverture : MonoBehaviour
{
    [SerializeField]
    private GameObject  wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "barel")
        {
            
            gameObject.transform.Translate((Vector3.down/2)*Time.deltaTime);
            wall.GetComponent<Animator>().SetBool("isFalling",true);
        }
    }
}
