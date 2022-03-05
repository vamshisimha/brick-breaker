using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BallMovement : MonoBehaviour
{
    
    private PaddleMovement paddle;
    Rigidbody2D rb;
    bool start = false;
    public AudioClip saw;
    private AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();
        paddle =GameObject.Find("Pad").GetComponent<PaddleMovement>();
        rb = GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetMouseButtonDown(0)&& start==false)
        {
            rb.velocity = new Vector2(0, 15) ;
            start = true;
            
        }
        if (start == false)
        {
            Vector2 ballPosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y + 0.5f);
            transform.position = ballPosition;
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Brick")
        {
            Destroy(collision.gameObject);
            ad.PlayOneShot(saw, 1.0f);
            
            
        }
    }
  /*  private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="DealWall")
        {
            gameObject.SetActive(false);
            Invoke("RepeatLevel", 0.8f);
        }
    }*/
}
