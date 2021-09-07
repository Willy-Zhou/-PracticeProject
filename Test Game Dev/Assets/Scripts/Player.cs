using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rigidbody2d;
    private float inputHorizontal;
    private float inputVertical;
    public LayerMask whatIsRope;
    public float distance;
    public bool isClimbing;

    private void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();

    }

    private void Update() {
        inputHorizontal = Input.GetAxis("Horizontal");
        rigidbody2d.velocity = new Vector2(inputHorizontal * speed, rigidbody2d.velocity.y);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsRope);
        if(hitInfo.collider != null){
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                isClimbing = true;
            }
        } else {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)){
            isClimbing = false;
        }
        }
        if(isClimbing == true && hitInfo.collider != null){
            inputVertical = Input.GetAxis("Vertical");
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, inputVertical * speed);
            rigidbody2d.gravityScale = 0;
        } else {
            rigidbody2d.gravityScale = 5;
        }


    }


}
