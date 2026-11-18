using NUnit.Framework.Internal;
using UnityEngine;

public class FTA_HexRotate : MonoBehaviour
{

    string shapeName;
    
    
    int randomCount;
    
    [SerializeField] Rigidbody2D myBody;

    public void StartRotate(){

    }

    void OnTriggerEnter2D(Collider2D other){
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        myBody.AddTorque(0.03f);

        randomCount = randomCount + Random.Range(1, 5);
        Debug.Log("randomCount");
        randomCount--;
    }


}
