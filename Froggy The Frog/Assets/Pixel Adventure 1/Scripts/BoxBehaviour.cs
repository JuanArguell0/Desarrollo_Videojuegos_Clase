using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    private string destroyerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("gameObject"))
        {
            destroyerName = collision.gameObject.name;

            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Debug.Log("Box destroyed by: " + destroyerName);
    }
}