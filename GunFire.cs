using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public float Damage = 10f;
    public GameObject BloodSpray;
    [SerializeField]
    private ParticleSystem particle;
    [SerializeField]
    private AudioClip clip;
    private AudioSource akSound;
    private Ray _ray;
    private new Camera camera;
    
    





    void Start()
    {

         
         akSound = GetComponent<AudioSource>();
         camera = Camera.main;


    }

    void Update()
    {
        

        if (Input.GetButton("Fire1"))
        {
            RifleGunFire();
            Shoot();

        }
    }

    private void Shoot()
    {
        Vector3 point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);
        _ray = camera.ScreenPointToRay(point);
        RaycastHit hitInfo;
        if (Physics.Raycast(_ray, out hitInfo))
        {
            Zombie zombie = hitInfo.transform.GetComponent<Zombie>();
            if (zombie != null)
            {
                zombie.TakeDamage(Damage);
                GameObject Blood = Instantiate(BloodSpray, hitInfo.point, hitInfo.transform.rotation);
                Destroy(Blood, 0.5f);
            }

        }
    }

    public void RifleGunFire()
    {
        particle.Play();
        akSound.Play();
    }

}
