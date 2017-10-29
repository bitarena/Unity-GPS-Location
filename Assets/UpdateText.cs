using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

    public Text coordinates;

	void Update () {
		coordinates.text = "Lat: " + TestLocationService.Instance.latitude.ToString() + "Long: " + TestLocationService.Instance.longitude.ToString();
	}
}
