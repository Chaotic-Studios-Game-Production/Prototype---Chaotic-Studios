using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    private Vector3 desDirection;// new Vector2(5,5);

    // Start is called before the first frame update
    void Start()
    {
        
        desDirection = Input.mousePosition;
        desDirection.z = 0;
        desDirection = Camera.main.ScreenToWorldPoint(desDirection);
        desDirection = desDirection - transform.position;
        desDirection.z = 0;
        desDirection = Vector3.ClampMagnitude(desDirection, 1.0f);
        StartCoroutine(DestroyObj());
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(desDirection * speed * Time.deltaTime);
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
