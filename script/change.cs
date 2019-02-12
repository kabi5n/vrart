using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class change : MonoBehaviour
{
    public int num;
    void OnCollisionEnter(Collision collision)
    {
     
 
        SceneManager.LoadScene("art"+num);
    }
}