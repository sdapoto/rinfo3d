using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {

	// CONSTANTES
	public static int CANT_CALLES = 100;
	public static int CANT_AVENIDAS = 100;
	public static float ELEVACION_CIUDAD = -0.01f;
	public static float ELEVACION_CALLEAV = 0.01f;
	public static float ANCHO_CALLEAV = 0.25f;

	// Prefab ciudad, calles y avenidas para inicializar ciudad
	public Transform ciudadPrefab;
	public Transform callePrefab; 
	public Transform avenidaPrefab; 

	// Use this for initialization
	void Start () {
		// Inicializar ciudad
		Object ciudadInstance = Instantiate (
				ciudadPrefab, 
				new Vector3 (CANT_AVENIDAS / 2 + .5f, ELEVACION_CIUDAD, CANT_CALLES / 2 + .5f ), 
				Quaternion.identity
			);
		((Transform)ciudadInstance).localScale = new Vector3 (CANT_AVENIDAS / 10, 0.01f, CANT_CALLES / 10);

		// Inicializar calles
		for (int z = 1; z <= CANT_CALLES; z++) {
			Object calleInstance = Instantiate(callePrefab, new Vector3(CANT_CALLES/2 + .5f, ELEVACION_CALLEAV, (float)z), Quaternion.identity);
			((Transform)calleInstance).localScale = new Vector3 (CANT_CALLES - 1, ELEVACION_CALLEAV, ANCHO_CALLEAV);
		}

		// Inicializar avenidas
		for (int x = 1; x <= CANT_AVENIDAS; x++) {
			Object avenidaInstance = Instantiate(avenidaPrefab, new Vector3((float)x, ELEVACION_CALLEAV, CANT_AVENIDAS/2 + .5f), Quaternion.identity);
			((Transform)avenidaInstance).localScale = new Vector3 (ANCHO_CALLEAV, ELEVACION_CALLEAV, CANT_AVENIDAS - 1);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
