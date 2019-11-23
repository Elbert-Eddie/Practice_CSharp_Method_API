using UnityEngine;

public class fox : MonoBehaviour
{
    [Header("移動速度"), Range(0, 50)]
    public float speed = 10;

    public Rigidbody2D Rig;

    public SpriteRenderer Sr;

    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }
}
