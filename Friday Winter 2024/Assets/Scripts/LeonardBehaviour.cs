using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeonardBehaviourScript : MonoBehaviour
{
    Animator animator;
    public GameObject player; // connect to player in Unity
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // connect to propety in Unity
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        animator.SetInteger("State", distance < 5 ? 1 : 0);
    }
}
