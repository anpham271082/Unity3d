using UnityEngine;

public class FruitNinjaBomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider>().enabled = false;
            FruitNinjaGameManager.Instance.Explode();
        }
    }

}
