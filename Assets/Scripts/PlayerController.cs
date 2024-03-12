using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
  [SerializeField] private float speed;

  void Start()
  {

  }

  void Update()
  {

    // move player
    if (Input.GetKey(KeyCode.D))
    {
      transform.position += new Vector3(0.1f, 0, 0) * Time.deltaTime * speed;
    }
    if (Input.GetKey(KeyCode.A))
    {
      transform.position += new Vector3(-0.1f, 0, 0) * Time.deltaTime * speed;
    }

    // jump
    if (Input.GetKeyDown(KeyCode.Space))
    {
      GetComponentInChildren<Rigidbody2D>().velocity = new Vector2(0, 0);
      GetComponentInChildren<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
    }

  }
}
