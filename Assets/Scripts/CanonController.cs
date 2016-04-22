using UnityEngine;
using System.Collections;

public class CanonController : MonoBehaviour {
    public GameObject ballPrefab;
    public GameObject muzzle;

    public float ballForce;
    public float rotSpeed;

    void Update()
    {
        RotateCamera();
        

        //ボールを打つ
        if (TouchUtil.GetTouch() == TouchInfo.Began)
        {
            Debug.Log("Fire On");
            ShootTheBall();
        }
    }


    public void RotateCamera()
    {
        /*
        //角度を変える
        float rotX = 0f;
        float rotY = 0f;

        rotX += Input.GetAxis("Horizontal") * rotSpeed;
        transform.Rotate(new Vector3(0, 1, 0), rotX);

        rotY += Input.GetAxis("Vertical") * rotSpeed * -1;
        transform.Rotate(new Vector3(1, 0, 0), rotY);
        */

        /*
        float yRot = Input.GetAxis("Mouse X") * rotSpeed;
        float xRot = Input.GetAxis("Mouse Y") * rotSpeed;
        transform.Rotate(-xRot, yRot, 0f);
        */

        //TouchUtil.GetTouch();

    }

    void ShootTheBall()
    {
        GameObject ball = Instantiate(ballPrefab, muzzle.transform.position, Quaternion.identity) as GameObject;
        ball.GetComponent<Rigidbody>().AddForce(transform.forward * ballForce, ForceMode.Impulse);

    }

}
