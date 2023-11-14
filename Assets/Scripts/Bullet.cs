using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed = 30f;
    private float _timelife = 5f;
    public GameObject _explosionEffect;
    private bool alreadyDestroyed = false;

    public Health Player;

    void Start()
    {
        /*if (!alreadyDestroyed)
        {
            Destroy(gameObject, _timelife);
        }*/
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
    }
    
    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")

            alreadyDestroyed = true;
            Player.TakeDamage(5);
             Debug.Log("ouch");
            //Instantiate(_explosionEffect, transform.position, Quaternion.identity);
            Destroy (gameObject);

    }

}
