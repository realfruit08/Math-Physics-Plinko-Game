using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Moving : MonoBehaviour
{
    public float newGravityScale = 2f; 
    public float defaultGravityScale = 0f; 
    private Rigidbody2D rb2d; 

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = defaultGravityScale;
    }
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
    }
}



