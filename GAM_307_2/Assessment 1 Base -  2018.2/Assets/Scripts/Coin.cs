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

    [SerializeField]
    private GameObject collectCoinEffect; //the particle effect will instantiate on pickup
    [SerializeField]
     
    private float startingY; //coins Y starting position gives us a value so we know how far it strays from inital position 
    private bool isMovingUp = true; // 

 void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Pickup();
        }
    }

    private void Pickup()
    {
        GameManager.Instance.NumCoins++;
        Instantiate(collectCoinEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    // Use this for initialization
    void Start() {
        //StartCoroutine(Spin ());
        //StartCoroutine(Float());

        startingY = transform.position.y;

        transform.Rotate(transform.up, Random.Range(0f, 360f));

    }
     void Update()
        {
            Spin();
            Float();
        }
      
    private void Spin()
       
          
            {
               transform.Rotate (transform.up, 360 *rotateSpeed* Time.deltaTime);
               // yield return 0;
            }
       

    private void Float()
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
          //  yield return 0;
        
    }
   
}
