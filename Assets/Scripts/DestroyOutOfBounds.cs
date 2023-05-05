using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 30;
    public float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { // Se um objeto passar da visão do jogo, remova esse objeto
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);

        }
        else if (transform.position.y < lowerBound)
        {
            Debug.Log("Game Over");

            Destroy(gameObject);
        }
    }
}
