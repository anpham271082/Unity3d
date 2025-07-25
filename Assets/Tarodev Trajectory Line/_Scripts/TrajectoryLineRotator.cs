using UnityEngine;

public class TrajectoryLineRotator : MonoBehaviour {
    [SerializeField] private Vector3 _rot;


    private void Update() {
        transform.Rotate(_rot * Time.deltaTime);
    }
}