using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad : MonoBehaviour {
	public GameObject Player;
	[System.Serializable]
	public class Position
	{
		public float x;
		public float y;
		public float z;

	}
	public void OnSave()
	{
		Position position = new Position ();
		position.x = Player.transform.position.x;
		position.y = Player.transform.position.y;
		position.z = Player.transform.position.z;
		if (!Directory.Exists (Application.dataPath + "/saves"))
			Directory.CreateDirectory (Application.dataPath + "/saves");
		FileStream fs = new FileStream (Application.dataPath + "/saves/save.sm", FileMode.Create);
		BinaryFormatter formatter = new BinaryFormatter ();
		formatter.Serialize (fs, position);
		fs.Close ();
	}

	public void onLoad()
	{
		if (File.Exists (Application.dataPath + "/saves/save.sm")) {
			FileStream fs = new FileStream (Application.dataPath + "/saves/save.sm", FileMode.Open);
			BinaryFormatter formatter = new BinaryFormatter ();
			try {
				Position pos = (Position)formatter.Deserialize (fs);
				Player.transform.position = new Vector3 (pos.x, pos.y, pos.z);
			} catch (System.Exception e) {
				Debug.Log (e.Message);
			} finally {
				fs.Close();
			}
		}
		else 
		{
			Application.Quit();
		}
	}
}
