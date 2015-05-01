using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	// Posibles estados de la GUI
	public const int STATE_EDITING = 0;
	public const int STATE_RUNNING = 1;
	public const int STATE_CONFIG  = 2;
	
	// Estado actual de la GUI. Inicia en EDITING logicamente
	public static int currentState = STATE_EDITING;

	void OnGUI() { 
		switch (currentState) { 	
			case STATE_EDITING: {
				renderEditing();
				break;
			}
			case STATE_RUNNING: {
				renderRunning();
				break;
			}
			case STATE_CONFIG: {
				renderConfig();
				break;
			}
		}



	}

	/** Renders the Editing Menu */
	void renderEditing() {

	}

	/** Renders the Running Menu */
	void renderRunning() {
		
	}

	/** Renders the Config Menu */
	void renderConfig() {
		
	}

}
