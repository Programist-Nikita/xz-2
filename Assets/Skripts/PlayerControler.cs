using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int speed = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector3(1,0,0) * Time.deltaTime * speed);
    }
}
