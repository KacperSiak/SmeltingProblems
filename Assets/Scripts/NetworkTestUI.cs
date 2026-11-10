using UnityEngine;
using Unity.Netcode;

public class NetworkTestUI : MonoBehaviour
{
    private void OnGUI()
    {
        if (NetworkManager.Singleton == null) return;

        GUILayout.BeginArea(new Rect(15, 15, 200, 150));

        if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            if (GUILayout.Button("Start Host (Serwer + Gracz)", GUILayout.Height(35)))
                NetworkManager.Singleton.StartHost();

            if (GUILayout.Button("Start Client (Do³¹cz)", GUILayout.Height(35)))
                NetworkManager.Singleton.StartClient();
        }
        else
        {
            GUILayout.Label($"Tryb: {(NetworkManager.Singleton.IsHost ? "Host" : "Klient")}");
        }

        GUILayout.EndArea();
    }
}