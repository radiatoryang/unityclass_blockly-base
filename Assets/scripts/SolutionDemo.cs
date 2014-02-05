using UnityEngine;
using System.Collections;

// this script inherits from Blockly.cs instead of just MonoBehaviour
// so it also has access to all the functions inside Blockly.cs! wow!

// all Blockly *functions* start with the word "Blockly"...

public class SolutionDemo : Blockly {

	// FixedUpdate is called every X seconds... "X" is defined in Edit >> Project Settings >> Time
	void FixedUpdate () {

		// move forward
		BlocklyMove ( transform.forward );

		// if we detect a wall that is 2 units in front of us, then turn 45 degrees to the left
		if ( BlocklyDetectWall ( transform.forward, 2f ) ) {
			BlocklyTurn ( -45f );
		}

	}
}
