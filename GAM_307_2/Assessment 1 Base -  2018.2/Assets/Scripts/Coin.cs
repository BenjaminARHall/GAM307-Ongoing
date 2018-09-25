using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    [SerializeField]
    private float rotateSpeed = 1.0f; //coin spin speed

    [SerializeField]
    private float floatSpeed = 0.5f; //coins vertical movement speed

    [SerializeField]
    private float movementDistance = 0.5f; //coins movement distance

    private float startingY; //coins Y starting position gives us a value so we know how far it strays from inital position 
    private bool isMovingUp = true; // 


    // Use this for initialization
    void Start() {
         StartCoroutine(Spin ());
         StartCoroutine(Float());

        startingY = transform.position.y;

        transform.Rotate(transform.up, Random.Range(0f, 360f));
       
        
    }
    private IEnumerator Spin()
        {
            while (true)
            {
               transform.Rotate (transform.up, 360 *rotateSpeed* Time.deltaTime);
                yield return 0;
            }
        }

    private IEnumerator Float()
    {
        while (true)
        {
            float newY = transform.position.y + (isMovingUp ? 1 : -1) * 2 * movementDistance * floatSpeed * Time.deltaTime;
            if (newY > startingY + movementDistance)
            { newY = startingY + movementDistance;
                isMovingUp = false;
            }
            else if (newY < startingY)
            { newY = startingY;
                isMovingUp = true;
            }

            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
            yield return 0;
        }
    }
	
	
}
