using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateScript : MonoBehaviour
{
    void Start()
    {
        Invoke("Deactivate", Random.Range(3f, 6f));
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
    }
}
