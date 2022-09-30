using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D Player;
    Vector2 direction;

    [SerializeField]
    float movementSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * 2 *Time.deltaTime * movementSpeed;
        direction.y = Input.GetAxis("Vertical") * 10 * Time.deltaTime * movementSpeed;

        //y = input.GetAxis
        //
    }

    // used to apply physics.
    private void FixedUpdate()
    {
        Player.AddForce(direction, ForceMode2D.Impulse);
    }
}

