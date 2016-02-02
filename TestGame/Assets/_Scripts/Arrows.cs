using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class Arrows : MonoBehaviour {

	private float startTime, timeElapsed;
	public GameObject downArrow, upArrow, leftArrow, rightArrow;
	private string[] beatMap = new string[200	];
	private int counter, number, frameNumber, stringCounter, sizeOfString, charCounter = 0;
	private float firstNumber = 20.5238f;
	private TextAsset textFile;

	// Use this for initialization
	void Start ()
	{
		startTime = Time.time;
		textFile = (TextAsset)Resources.Load ("Sample");
		
		StringReader reader = new StringReader (textFile.text);
		string text;
		do
		{
			text = reader.ReadLine();
			beatMap[counter++] = text;
		} while (text != null);
		sizeOfString = beatMap [stringCounter].Length;
	}
	
	// Update is called once per frame
	void Update () {
		frameNumber++;
		timeElapsed = (Time.time - startTime) * 1000;
		if (timeElapsed > firstNumber && beatMap[stringCounter+1][charCounter] != '%') {
			Spawn (beatMap [stringCounter] [charCounter++]);
			if (charCounter == sizeOfString && beatMap[stringCounter] != null) {
				charCounter = 0;
				stringCounter++;
				sizeOfString = beatMap [stringCounter].Length;
			}
			firstNumber+=59.5238f;
		}
	}


	void Spawn(char l)
	{
		if (l.Equals ('L')) {
			Instantiate (leftArrow, new Vector3 (-11f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print (("Left "));
		} else if (l.Equals ('R')) {
			Instantiate (rightArrow, new Vector3 (-6.5f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print (("Right") );
		} else if (l.Equals ('U')) {
			Instantiate (upArrow, new Vector3 (-8f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print (timeElapsed);
		} else if (l.Equals ('D')) {
			Instantiate(downArrow,new Vector3(-9.5f,14f,0f), new Quaternion(0f,0f,0f,0f));
			//print(("Down"));
		}
		else if (l.Equals ('Z')) {
			Instantiate(downArrow,new Vector3(-9.5f,14f,0f), new Quaternion(0f,0f,0f,0f));
			Instantiate (upArrow, new Vector3 (-8f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Down and Up"));
		}
		else if (l.Equals ('K')) {
			Instantiate (upArrow, new Vector3 (-8f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			Instantiate (leftArrow, new Vector3 (-11f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Up and Left"));
		}
		else if (l.Equals ('C')) {
			Instantiate (upArrow, new Vector3 (-8f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			Instantiate (rightArrow, new Vector3 (-6.5f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Up and Right"));
		}
		else if (l.Equals ('V')) {
			Instantiate(downArrow,new Vector3(-9.5f,14f,0f), new Quaternion(0f,0f,0f,0f));
			Instantiate (leftArrow, new Vector3 (-11f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Down and Left"));
		}
		else if (l.Equals ('N')) {
			Instantiate(downArrow,new Vector3(-9.5f,14f,0f), new Quaternion(0f,0f,0f,0f));
			Instantiate (rightArrow, new Vector3 (-6.5f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Down and Right"));
		}
		else if (l.Equals ('B')) {
			Instantiate (leftArrow, new Vector3 (-11f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			Instantiate (rightArrow, new Vector3 (-6.5f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Left and Right"));
		}
		else if (l.Equals ('M')) {
			Instantiate (upArrow, new Vector3 (-8f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			Instantiate (leftArrow, new Vector3 (-11f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			Instantiate (rightArrow, new Vector3 (-6.5f, 14f, 0f), new Quaternion (0f, 0f, 0f, 0f));
			//print(("Up and Left and Right"));
		}

			


		return;
	}
		
}
	