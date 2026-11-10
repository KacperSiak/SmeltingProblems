using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] private float speed = 6f;

    void Update()
    {
        if (!IsOwner) return;

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0, z).normalized;
        transform.position += move * (speed * Time.deltaTime);
    }
    public override void OnNetworkSpawn()
    {
        Debug.Log($"[{name}] Owner: {OwnerClientId}, Ja: {NetworkManager.LocalClientId}, IsOwner: {IsOwner}");
    }
}