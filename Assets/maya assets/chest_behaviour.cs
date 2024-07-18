using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update

    public GameObject objectToSpawn;
    public Transform spawnPoinbt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnTriggerEnter(Collider other)
{
if (other.tag == "Player")
        {
            //play the animation
            animator.SetTrigger("Open");
        }
}

private void OnTriggerExit(Collider other)
{
    if (other.tag != "Player")
        {
            //play the animation
            animator.SetTrigger("Close");
        }
}


}
