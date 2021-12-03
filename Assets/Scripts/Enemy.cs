using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float runningSpeed = 1.5f;
    public int enemyDamage = 10;

    Rigidbody2D rigiBody;

    public bool facingRight = false;
    
    private Vector3 starPosition;


    private void Awake()
    {
        rigiBody = GetComponent<Rigidbody2D>();
        starPosition = this.transform.position;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = starPosition;
    }

    private void FixedUpdate()
    {
        float currentRunningSpeed = runningSpeed;
        if (facingRight)
        {
            //Mirando hacia la derecha
            currentRunningSpeed = runningSpeed;
            this.transform.eulerAngles = new Vector3(0,180,0);
        }else{
            //Mirando hacia la izquierda
            currentRunningSpeed = -runningSpeed;
            this.transform.eulerAngles = Vector3.zero;
        }
        if (GameManager.sharedInstance.currentGameState == GameState.inGame)
        {
            rigiBody.velocity = new Vector2(currentRunningSpeed, rigiBody.velocity.y);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            return;
        }
        if(collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().CollectHealth(-enemyDamage);
            return;
        }
        //Si llegamos aqui, no hemos chocado ni con monedas, ni con players
        //Lo más normal es que aquí haya otro enemigo o bien escenario
        //Vamos a hacer que el enemigo rote
        facingRight = !facingRight;
    }
}
