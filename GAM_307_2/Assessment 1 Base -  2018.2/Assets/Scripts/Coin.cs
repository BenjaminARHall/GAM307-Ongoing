using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    [SerializeField]
    private float rotateSpeed = 1.0f;

    // Use this for initialization
    void Start() {
        StartCoroutine(Spin ());
    }
    private IEnumerator Spin()
        {
            while (true)
            {
               transform.Rotate (transform.up, 360 *rotateSpeed* Time.deltaTime);
                yield return 0;
            }
        }
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
