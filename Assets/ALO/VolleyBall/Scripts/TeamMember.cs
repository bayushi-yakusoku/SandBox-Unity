using UnityEngine;

public class TeamMember : MonoBehaviour {
    const string IS_VICTORIOUS = "isVictorious";

    [SerializeField] bool isVictorious = false;

    Animator animator;

    private void Awake() {
        // get the animator component
        animator = GetComponent<Animator>();
    }

    private void Update() {
        // set the isVictorious parameter in the animator
        animator.SetBool(IS_VICTORIOUS, isVictorious);
    }
}
