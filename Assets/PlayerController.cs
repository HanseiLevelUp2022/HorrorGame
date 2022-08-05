using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform camTf;
    public float speed = 8;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, camTf.rotation.eulerAngles.y,
            camTf.rotation.eulerAngles.z));
        
        var input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(input.normalized * (Time.deltaTime * speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("적한테 부딫혔음");
        }
    }
}
