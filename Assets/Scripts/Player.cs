using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public int hp = 5;
    public Transform misil;
    public Transform shootPoint;
    private float timeDestroy = 4f;

    public GameObject go;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        var mov = new Vector3(moveHorizontal, moveVertical, 0);
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = mov * speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("disparo");
            Transform bullet = Instantiate(misil, shootPoint.transform.position, shootPoint.transform.rotation);
            Destroy(bullet.gameObject, timeDestroy);

        }
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("me") || other.gameObject.CompareTag("Esteroide"))
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
            go.SetActive(true);
            Debug.Log("PERDISTEEEE");
        }
    }
}
