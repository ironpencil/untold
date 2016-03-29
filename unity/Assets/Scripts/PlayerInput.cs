using UnityEngine;
using System.Collections;
using Prime31;

public class PlayerInput : MonoBehaviour {

    CharacterController2D cc2d;

    void Awake ()
    {
        //cache cc2d
        cc2d = gameObject.GetComponent<CharacterController2D>();
    }

	// Update is called once per frame
	void Update () {

        if (Globals.Instance.acceptPlayerGameInput)
        {
            HandleMovement();
        }
	
	}


    void HandleMovement()
    {

        float horizontal = 0.0f;
        //float vertical = 0.0f;

            horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");

        //float horizontalMovement = 0.0f;
        //float verticalMovement = 0.0f;

        //if (horizontal > 0.0f)
        //{
        //    horizontalMovement = 1.0f;
        //}
        //else if (horizontal < 0.0f)
        //{
        //    horizontalMovement = -1.0f;
        //}

        //if (vertical > 0.0f)
        //{
        //    verticalMovement = 1.0f;
        //}
        //else if (vertical < 0.0f)
        //{
        //    verticalMovement = -1.0f;
        //}
        Vector2 deltaMove = new Vector2(horizontal, 0.0f);

        cc2d.move(deltaMove);

    }
}
