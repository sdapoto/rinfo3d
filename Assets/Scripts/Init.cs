using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	// Numero de calles y avenidas
	public static int CANT_CALLES = 100;
	public static int CANT_AVENIDAS = 100;

	// Prefab calles y avenidas para inicializar ciudad 100x100
	public Transform callePrefab; 
	public Transform avenidaPrefab; 

	// Use this for initialization
	void Start () {
		// Inicializar calles y avenidas
		for (int z = 1; z <= CANT_CALLES; z++) {
			Instantiate(callePrefab, new Vector3(50.5f, 0f, (float)z), Quaternion.identity);
		}
		// Inicializar calles y avenidas
		for (int x = 1; x <= CANT_AVENIDAS; x++) {
			Instantiate(avenidaPrefab, new Vector3((float)x, 0f, 50.5f), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
