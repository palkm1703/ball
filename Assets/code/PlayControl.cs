using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int score;
    public Text scoreText;
    public Text win;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        score=0;
        SetScoreText ();
        win.text=" ";
    }

    // Update is called once per frame
    void Update()
    {
       float moveHorizontal=Input.GetAxis("Horizontal");
       float moveV=Input.GetAxis("Vertical");
       Vector3 movement=new Vector3(moveHorizontal,0.0f,moveV);
       rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"));
        {
            other.gameObject.SetActive(false);
            score=score+1;
            SetScoreText ();
        }
    }
    void SetScoreText()
    {
      scoreText.text = "Score:" +score.ToString();
      if(score >=12)
      {
          win.text="you win";
      }
    }
}
