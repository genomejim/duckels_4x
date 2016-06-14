using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour
{
    
   
    // Use this for initialization
    void Start()
    {
        Debug.Log("Debug String");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertocal");
        Debug.Log(movex.ToString());
        Debug.Log("Debug String");
        float x_move = 2.55f;
        if (movex > 0)
        {
            gameObject.transform.Translate(x_move, 0, 0);
        }
    }

}
