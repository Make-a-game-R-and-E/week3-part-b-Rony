using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;
    public float maxX = 7.5f;
    float movmentHorizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movmentHorizontal = Input.GetAxis("Horizontal");
        if ((movmentHorizontal > 0 && transform.position.x < maxX) || (movmentHorizontal < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * movmentHorizontal * speed * Time.deltaTime;
        }
    }
}
