using UnityEditor;
using UnityEngine;

public class SpawnOnDeath : MonoBehaviour
{
    [SerializeField] private float howMany = 2; 
    [SerializeField] private float heightSpawnMult = 1.5f;
    [SerializeField] private GameObject prefabToSpawn;
    private float _spawnLocationX;
    private float x_offset;
    private float y_offset;
    private Vector3 size;

    void Start()
    {
        size = GetComponent<Collider2D>().bounds.size;
        _spawnLocationX = GetComponent<Transform>().position.x - size.x/2;
        x_offset = size.x / howMany;
        y_offset = heightSpawnMult * size.y;
    }
    private void OnDestroy() {
        Vector3 pos = GetComponent<Transform>().position;
        pos.y += y_offset;
        float dir = 1.0f;
        float start_x = pos.x;
        for(int i=0; i < howMany; ++i)
        {
            pos.x = start_x + dir * x_offset;
            dir *= -1.0f;
            Instantiate(prefabToSpawn, pos, Quaternion.identity); //https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
        }
    }
}