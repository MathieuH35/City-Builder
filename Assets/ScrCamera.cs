using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrCamera : MonoBehaviour
{
    public float sensitivity_H = 5;
    public float sensitivity_V = 5;
    public float sensitivity_zoom = 5;
    // Start is called before the first frame update
    void Start()
    {
        _camera = gameObject.GetComponentInChildren<Camera>();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        _camera.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        gameObject.transform.position = new Vector3(0.0f, 10.0f, 0.0f);
        gameObject.transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        _camera.transform.localEulerAngles = new Vector3(45f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float moveUp = Input.GetAxis("Vertical") * sensitivity_V * Time.deltaTime * 30;
        float moveSide = Input.GetAxis("Horizontal") * sensitivity_H * Time.deltaTime * 30;
        float zoom = Input.GetAxis("Mouse ScrollWheel") * sensitivity_zoom * Time.deltaTime * 30;
        gameObject.transform.Translate(moveSide, 0.0f, moveUp);
    }

    private Camera _camera;
}