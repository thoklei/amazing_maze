using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitedLifetime : MonoBehaviour
{
    [SerializeField] private float lifetime = 1; // lifetime in seconds

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destruction());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Destruction() {
        yield return new WaitForSeconds(this.lifetime);
        Destroy(this.gameObject);
    }
}
