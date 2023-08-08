using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Haalt Rigidbody op en wordt intern 'rb' genoemd. Zorg dat in Unity 'rb' gekoppeld is aan Rigidbody.
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sideForce = 500f;


    // Start is called before the first frame update. Initiallization. Deze code draait (eenmalig) wanneer de game start.
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame. Iedere keer wanneer de computer een nieuw beeld genereert, wordt deze code uitgevoerd

    // FixedUpdate i.p.v. Update, dit omdat er binnen deze functie berekeningen worden uitgevoerd met de Unity physics 
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Voegt een Force van 2.000 * Time.deltaTime op het object toe aan de Z-as.

        // Time.deltaTime
        // * Time.DeltaTime: Aantal seconden sinds het laatste beeld gegenereert is. Dit om de force even te verdelen (anders zou de speler sneller gaan bij meer FPS, omdat deze code voor iedere frame wordt uitgevoerd)
        // 10 FPS: 200 * 0.1 = 20 force (0,1 sec. sinds laatste frame)
        // 20 FPS: 200 * 0.05 = 10 force (0,05 sec sinds laatste frame)

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
