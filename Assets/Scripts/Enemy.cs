using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp = 3;
    public Transform misil;
    public Transform shootPoint;
    private float timeFire = 1.5f;
    private float timeDestroy = 4f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0.03f, 0));
    }

    IEnumerator Shoot()
    {        
        Debug.Log("dispara enemy");
        yield return new WaitForSeconds(timeFire);
        Transform cannonb = Instantiate(misil, shootPoint.transform.position, shootPoint.transform.rotation);
        Destroy(cannonb.gameObject, timeDestroy);
        StartCoroutine(Shoot());       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("mp"))
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
