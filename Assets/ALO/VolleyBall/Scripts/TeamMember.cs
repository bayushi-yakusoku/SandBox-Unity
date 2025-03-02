using UnityEngine;

public class TeamMember : MonoBehaviour {
    const string IS_VICTORIOUS = "isVictorious";
    const string IS_RECEIVING = "isReceiving";

    [SerializeField] bool isVictorious = false;
    [SerializeField] bool isReceiving = false;

    Animator animator;

    private void Awake() {
        // get the animator component
        animator = GetComponent<Animator>();
    }

    private void Update() {
        // set the isVictorious parameter in the animator
        animator.SetBool(IS_VICTORIOUS, isVictorious);

        // set the isReceiving parameter in the animator
        animator.SetBool(IS_RECEIVING, isReceiving);
    }
}
