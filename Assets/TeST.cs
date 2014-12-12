using UnityEngine;
using System.Collections;

public class TeST : MonoBehaviour {
    public AudioSource _Stage1;
    public AudioSource _Stage2;
    private bool Test = false;
	// Use this for initialization
	void Start () {
        _Stage1.Play();
        _Stage2.Stop();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.A))
        {
            Test = true;
        }

        if(Test = true)
        {
            _Stage1.Pause();
            _Stage2.Play();
        }
	}
}
