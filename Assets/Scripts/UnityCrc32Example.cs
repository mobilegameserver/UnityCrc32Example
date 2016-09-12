using UnityEngine;

using System;

public class UnityCrc32Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DamienG.Security.Cryptography.Crc32 crc32 = new DamienG.Security.Cryptography.Crc32();

		string str = "aa";
		var bytes = new byte[str.Length];
		Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, str.Length);

		var hash = crc32.ComputeHash(bytes);

		if (BitConverter.IsLittleEndian)
			Array.Reverse(hash);

		int i = BitConverter.ToInt32(hash, 0);
		Debug.Log(i);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
