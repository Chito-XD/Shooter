using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re : MonoBehaviour
{
    float timer;
    public GameObject meteorPreb;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5f)
        {
            float ranPos = Random.Range(-4.5f, 6f);
            Vector3 pos = new Vector3(6.5f, ranPos, 0);
            timer = 0;
            Instantiate(meteorPreb, meteorPreb.transform.position, meteorPreb.transform.rotation);
        }
    }
}
