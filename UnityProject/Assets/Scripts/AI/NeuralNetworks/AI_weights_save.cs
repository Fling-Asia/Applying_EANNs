using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class AI_weights_save : MonoBehaviour {
    // Use this for initialization
    void Start () {
        //Write weights to file 
      //  var  = @"C:\Users\Ryzen1500X\Documents\GitHub\Applying_EANNs\UnityProject\MyTest.txt";
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(NeuralLayer.weights_revised);
        writer.Close();
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
