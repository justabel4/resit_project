using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
for some reasons cannonShoot doesnt work when it's in its own function 
so I duplicate the code to show that it works without being its own function
he UI and bouttons work, just the cannon doesnt shoot
*/


public class cannon_behaviour : MonoBehaviour

{
    public AudioClip cannonShot;
    public ParticleSystem smoke;
    public GameObject ui;


    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
    
        if(other.tag == "Player")
        {
            ShowUI();
        }
    }

    public void ShootCannon()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(cannonShot);

        smoke.Play();
    }

    public void HideUI()
    {
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes()
    {
        HideUI();
        ShootCannon();
    }

    public void PressNo()
    {
        HideUI();
    }


}


