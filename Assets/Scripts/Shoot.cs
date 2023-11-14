using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject _bullet;
    private int _counter = 0;
    private int _maxCounter = 20;
    private float _timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireBullets_CR());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireBullets_CR()
    {
        Debug.Log("Inicio coroutine");
        
        for(int i=0; i<_maxCounter; i++)
        {
            _counter++;
            GameObject bullet = Instantiate(_bullet, transform.position, transform.rotation);
            //bullet.GetComponent<Rigidbody>().velocity = transform.forward * 10; 
            yield return new WaitForSeconds(_timer);   
        } 

        Debug.Log("Fin coroutine");
    }

}
