using UnityEngine;

public class ColliderBridge : MonoBehaviour {

    IListener _listener;
    public IListener Listener {
        get => _listener;
        set {
            if (_listener != null) {
                Debug.LogWarning("ColliderBridge: Listener already set, replacing it.");
            }
            _listener = value;
        }
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(this + "reacting to CollisionEnter");
        _listener?.OnCollisionEnter(collision);
    }
}
