using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float _velocity;
    private float _distance;
    private void OnEnable()
    {
        transform.position = new Vector3(0, 0.5f, 0);
        _velocity = DataControll.Velocity;
        _distance = DataControll.Distance;
    }

    private void Update()
    {
        transform.position += new Vector3(0, 0, _velocity * Time.deltaTime);
        if(transform.position.z >= _distance) gameObject.SetActive(false);
    }
}
