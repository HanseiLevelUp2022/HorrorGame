using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform camTf;
    
    private void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, camTf.rotation.eulerAngles.y,
            camTf.rotation.eulerAngles.z));
    }
}
