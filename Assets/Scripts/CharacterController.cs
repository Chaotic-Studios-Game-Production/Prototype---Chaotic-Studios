using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField]
    GameObject shot;
    Vector3 direction;
    // Start is called before the first frame update
    SpriteRenderer sRenderer;
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.mousePosition;
        direction.z = 0;
        direction = Camera.main.ScreenToWorldPoint(direction);
        direction = direction - transform.position;
        Move();
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
        }
        Debug.Log(direction);

    }

    private void Move()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var newXPos = transform.position.x + deltaX;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var newYPos = transform.position.y + deltaY;
        transform.position = new Vector2(newXPos, newYPos);
        if(direction.x < 0)
        {
            sRenderer.flipX = true;
        }
        else if(direction.x> 0)
        {
            sRenderer.flipX = false;
        }

    }
}
