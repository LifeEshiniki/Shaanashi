using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour {
	public Text Iwayan;
	public Text Sachika;

	// Use this for initialization
	void Start () {
		Iwayan.text = "";
		Sachika.text = "";
		StartCoroutine("Iwaya");
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator Iwaya(){
		yield return new WaitForSeconds(1f);
		Sachika.text = "いわや～ん、バイトおつかれさまで～す";
		yield return new WaitForSeconds(2.5f);
		Sachika.text = "いくよ～、ハイかんぱいうぇーい";
		yield return new WaitForSeconds(0.1f);
		Iwayan.text = "うぇーい！";
		yield return new WaitForSeconds(2f);
		Sachika.text = "";
		Iwayan.text = "";
		yield return new WaitForSeconds(9.3f);
		Sachika.text = "いわやんおっそいね";
		yield return new WaitForSeconds(2f);
		Sachika.text = "まあバイト頑張ってるからしゃあなしかな";
		yield return new WaitForSeconds(3.7f);
		Iwayan.text = "オッケーす！";
		yield return new WaitForSeconds(1.5f);
		Sachika.text = "お疲れ様でーす　うぇーい";




	} 

}
