using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public string collecttag;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(collecttag))
        {

            Destroy(collision.collider.gameObject);
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
