using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSpace : MonoBehaviour {

    public GameObject Boulder_Emitter;

    public GameObject Boulder1;

    public float Forward_Force = 0;

	Rigidbody2D _rigid;

	public bool IsCharging = true;

	// Use this for initialization
	void Start () {
		_rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {


		//if (TimeElapsed > LaunchWindow) {
		//	IsCharging = false;
		//}

		if (Input.GetKeyDown(KeyCode.Space))
        {
			if (IsCharging) {
				Charge ();
			} else {
				Fire ();
			}
				        }
		
	}

	void Fire()
	{
		_rigid.bodyType = RigidbodyType2D.Dynamic;
		_rigid.AddForce (transform.right * Forward_Force, ForceMode2D.Impulse);
	}

	void Charge(){

		Forward_Force = Forward_Force + 5;

	}
		
}
