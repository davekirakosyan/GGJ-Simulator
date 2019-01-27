using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTyper : MonoBehaviour
{
    private int count;
    public Text text;
    private string fullText = "void FixedUpdate()\n    {\n        float h = Input.GetAxis();\n        if (h * rb2d.velocity.x < maxSpeed)\n            rb2d.AddForce(Vector2.right * h * moveForce);\n        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)\n            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);\n        if (h > 0 && !facingRight)";
        
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && count<345)
        {
            text.text+=char.ToString(fullText[count]);
            count++;
        }
    }
}
