using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] private float waitTime = 3;

    [SerializeField] private GameObject explosion;

    private GameObject exp;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explode());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Explode()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(this.gameObject);
        this.exp = Instantiate<GameObject>(this.explosion, this.transform.position, Quaternion.identity);
        exp.transform.parent = this.transform.parent;
    }

}
