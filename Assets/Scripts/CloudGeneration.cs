using UnityEngine;

public class CloudGeneration : MonoBehaviour
{
    public GameObject[] clouds;
    public Transform cam;
    int idx = 0;

    void Update()
    {
        if (transform.childCount < 6)
        {
            GameObject ins = Instantiate(clouds[idx], transform);
            ins.transform.position = cam.position + new Vector3(10, Random.value * 3 + 1.5f, +8);
            ins.GetComponent<CloudDeleter>().cam = cam;
            idx = (idx + 1) % 5;
        }
    }
}
