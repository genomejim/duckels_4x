﻿using UnityEngine;
using System.Collections;

public class ExplorerMovement : MonoBehaviour
{
    public int TurnNumber;
    bool new_turn;
    public UnityEngine.UI.Text TurnNumberText;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Debug String");
        new_turn = true;
        TurnNumberText.text = "1";
        TurnNumber = 1;
    }

    // Update is called once per frame
    public void NextTurn ()
    {
        new_turn = true;
    }

    void Update()
    {

        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.N) && !(new_turn))
        {
            new_turn = true;
            TurnNumber += 1;
            // TurnNumberText = GameObject.Find("TurnNumber").GetComponent<UnityEngine.UI.Text>();
            TurnNumberText.text = TurnNumber.ToString();
        }
        
        float move = 2.55f;
        if (movex > 0 && new_turn)
        {
            gameObject.transform.Translate(move, 0, 0);
            new_turn = false;
            Debug.Log(movex.ToString());
        }
        else if (movex< 0 && new_turn)
        {
            gameObject.transform.Translate(-move, 0, 0);
            Debug.Log(movex.ToString());
            new_turn = false;
        }
        if (movey > 0 && new_turn)
        {
            gameObject.transform.Translate(0, move, 0);
            new_turn = false;
            Debug.Log(movex.ToString());
        }
        else if (movey < 0 && new_turn)
        {
            gameObject.transform.Translate(0, -move, 0);
            Debug.Log(movex.ToString());
            new_turn = false;
        }
    }

}
