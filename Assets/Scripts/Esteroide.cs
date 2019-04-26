using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esteroide : MonoBehaviour
{
    private int hp = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObject.transform.Translate(new Vector3(0, 0.03f, 0));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("mp"))
        {
            GetDamage();
        }
    }

    public void GetDamage()
    {
        hp--;
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
