using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float moveAmount;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = this.transform;   
    }

    // Update is called once per frame
    void Update()
    {
        t.position = new Vector2(t.position.x, t.position.y + moveAmount);
        if (t.position.y >= 1.5 || t.position.y < 0.168)
        {
            moveAmount = -1 * moveAmount;
        }
    }
}
