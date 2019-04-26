using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.gameObject.tag == "mp")
        {
            gameObject.transform.Translate(new Vector3(0, .05f, 0));
        }
        else
        {
            gameObject.transform.Translate(new Vector3(0, -.05f, 0));
        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Toca al player");
            //FindObjectOfType<Player>().GetDamage();
            Destroy(this.gameObject);
        }
        else if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Toca a un enemigo");
            //FindObjectOfType<Enemy>().GetDamage();
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("Esteroide"))
        {
            Debug.Log("Toca a un esteroide");
            //ndObjectOfType<Esteroide>().GetDamage();
            Destroy(this.gameObject);
        }
    }
}
