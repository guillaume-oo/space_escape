using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
 
public class MoveBullet : MonoBehaviour
{
    public Vector3 hitPoint;
 
    // public GameObject dirt;
 
    public int speed;
 
    //public AudioSource myShot;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce((hitPoint - this.transform.position).normalized * speed);
    }
 
    // Update is called once per frame
    void Update()
    {
 
    }
 
    void OnCollisionEnter(Collision col)
    {
        if (this.gameObject.name != "Bullet")
        {
            if (col.gameObject.tag == "Ennemy")
            {
                col.gameObject.GetComponent<Health>().currentHealth -= 20;
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                // Instantiate(dirt, this.transform.position, this.transform.rotation);
                // Destroy(this.gameObject);
            }
    
            Destroy(this.gameObject);
        }
    }
}