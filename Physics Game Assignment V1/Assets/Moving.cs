using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving3 : MonoBehaviour
{
    public float newGravityScale = 2f;
    public float defaultGravityScale = 0f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = defaultGravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb2d.gravityScale == defaultGravityScale)
            { rb2d.gravityScale = newGravityScale;
            }
            else
            { rb2d.gravityScale = defaultGravityScale;
            }
        }
        float moveSpeed = 4f; 
        Input.GetKey(KeyCode.A); 
        Input.GetKey(KeyCode.D);
        if (rb2d.gravityScale != 2f)
        {
            if (Input.GetKey(KeyCode.A))
            { transform.position += Vector3.left * Time.deltaTime * moveSpeed;
            }
            if (Input.GetKey(KeyCode.D))
            { transform.position += Vector3.right * Time.deltaTime * moveSpeed;
            }
        }
    }
}
