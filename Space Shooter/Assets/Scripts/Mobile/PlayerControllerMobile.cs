using UnityEngine;
public class PlayerControllerMobile : MonoBehaviour
{
    public float xMinimum, xMaximum, zMinimum, zMaximum;
    public float speed;
    public float tilt;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public GameObject joystick;
    private float nextFire;
    void FixedUpdate()
    {
        float moveHorizontal = joystick.GetComponent<Joystick>().Horizontal;
        float moveVertical = joystick.GetComponent<Joystick>().Vertical;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, xMinimum, xMaximum),
            0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, zMinimum, zMaximum)
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
    }

    public void shoot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
}