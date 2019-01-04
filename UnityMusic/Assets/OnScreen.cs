using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreen : MonoBehaviour {

	public void PlayMusic(){
		Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
		script.SendEvent(Hv_UkuleleUnity_AudioLib.Event.Play);
	}

	public void StopMusic(){
		Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
		script.SendEvent(Hv_UkuleleUnity_AudioLib.Event.Stop);
	}

	public void SectionC(){
		Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
		script.SendEvent(Hv_UkuleleUnity_AudioLib.Event.C);
	}

	public void SectionE(){
		Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
		script.SendEvent(Hv_UkuleleUnity_AudioLib.Event.E);
	}
}
