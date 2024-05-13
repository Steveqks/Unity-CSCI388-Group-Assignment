using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDirectionalLight : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed for rotation")]
    private float mSpeed = 0.0f;

    private GameObject dirLight;

    private void Awake()
    {
        //This is calling initalizing whatever gameobject this script is on as the dirlight gameobject
        //Dont put this script into other than the directional light else they will rotate continously.
        dirLight = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dirLight.transform.Rotate(new Vector3(mSpeed * Time.deltaTime, 0, 0));
    }
}
