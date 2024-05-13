using Mirror;
using UnityEngine;

public class CameraManager : NetworkBehaviour
{
    public override void OnStartClient()
    {
        base.OnStartClient();

        if (isLocalPlayer) {
            GetComponent<Camera>().enabled = true;
            GetComponent<AudioListener>().enabled = true;
        }
    }
}
