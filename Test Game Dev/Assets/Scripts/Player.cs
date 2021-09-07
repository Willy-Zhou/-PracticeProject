using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D boxCollider;
    public Vector2 velocity;
    private Rigidbody2D rigidbody2d;
    private bool walk, walk_left, walk_right,jump;

    private void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
        rigidbody2d =transform.GetComponent<Rigidbody2D>();

    }

    private void Update() {
        // Reset MoveDelta
        
            CheckPlayerInput();

            UpdatePlayerPosition();
    }

    void UpdatePlayerPosition(){
        Vector3 pos = transform.localPosition;
        Vector3 scale = transform.localScale;

        if(walk){
            if(walk_left){
                pos.x -= velocity.x * Time.deltaTime;
                scale.x=-1;
            }
            if(walk_right){
                pos.x += velocity.x * Time.deltaTime;
                scale.x = 1;
            }
            if (jump){
                rigidbody2d.velocity = Vector2.up * velocity.y;
            }
        }
        transform.localPosition = pos;
        transform.localScale = scale;

    }

    private bool IsGrounded(){
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size,0f, Vector2.down *1f);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

    void CheckPlayerInput(){

        bool input_left = Input.GetKey(KeyCode.LeftArrow);
        bool input_right = Input.GetKey(KeyCode.RightArrow);
        bool input_space = Input.GetKey(KeyCode.Space);

        walk = input_left || input_right;

        walk_left = input_left || !input_right;
        walk_right = !input_left || input_right;
        jump = input_space;
    }


    


}
