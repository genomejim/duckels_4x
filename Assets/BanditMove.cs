using UnityEngine;
using System.Collections;

public class BanditMove : MonoBehaviour
{
    
    //public bool new_turn;
    float direction;
    public bool new_turn;

    // Use this for initialization
    void Start()
    {
        new_turn = true;
    }

    // Update is called once per frame
    

    void Update()
    {
        

        if (new_turn)
        {
            direction = Random.Range(0, 4f);
        }

        //new_turn = GameObject.Find("Explorer").GetComponent<ExplorerMovement>().bandit_new_turn;

        float move = 2.55f;
        //Debug.Log(new_turn);
        if (direction <1  && new_turn)
        {
            gameObject.transform.Translate(move, 0, 0);
            new_turn = false;
        
        }
        else if (direction < 2 && new_turn)
        {
            gameObject.transform.Translate(-move, 0, 0);
            new_turn = false;

        }
        else if (direction < 3  && new_turn)
        {
            gameObject.transform.Translate(0, move, 0);
            new_turn = false;
        }
        else if (direction < 4 && new_turn)
        {
            gameObject.transform.Translate(0, -move, 0);
            new_turn = false;
        }
    }

}