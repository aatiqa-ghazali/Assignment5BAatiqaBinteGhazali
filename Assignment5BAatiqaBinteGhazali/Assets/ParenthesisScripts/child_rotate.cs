 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child_rotate : MonoBehaviour
{
    
    public string x = "";
    // Start is called before the first frame update


    // Update is called once per frame

    void Update()
    {
        transform.Rotate(new Vector3(-15, -30, -45) * Time.deltaTime);
        

    }



    
}
