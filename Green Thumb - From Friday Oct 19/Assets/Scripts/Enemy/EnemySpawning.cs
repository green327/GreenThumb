using System.Collections;
using UnityEngine;

public class EnemySpawning : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnleastWait;
	public int startWait;
	int randomEnemy;
    public int enemyCap;
    int numEnemies;

	// Use this for initialization
	void Start ()
    {
        numEnemies = 0;
		StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
		spawnWait = Random.Range(spawnleastWait, spawnMostWait);	
	}

	IEnumerator waitSpawner(){
		yield return new WaitForSeconds(startWait);
		while(numEnemies < enemyCap){
			randomEnemy = Random.Range(0,2);
			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
			Instantiate (enemies[randomEnemy], spawnPosition + transform.TransformPoint (0,0,0), gameObject.transform.rotation);
            numEnemies++;
			yield return new WaitForSeconds(startWait);
		}
	}
}
