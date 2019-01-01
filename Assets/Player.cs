
using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class Player : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translationx =  - Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float translationy = 0;
        if(Input.GetAxis("Jump") > 0)
        {
            translationy = 0.3f;
        }
        float translationz =  Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        
        transform.Translate(translationx, translationy, translationz);

    }
}
