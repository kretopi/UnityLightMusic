using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	
public AudioClip melodyC1; //make AudioClip for every sound file
public AudioClip melodyC2;
public AudioClip melodyC3;
public AudioClip melodyC4;
public AudioClip melodyC5;
public AudioClip melodyC6;
public AudioClip melodyC7;
public AudioClip melodyC8;

public AudioClip melodyE1;
public AudioClip melodyE2;
public AudioClip melodyE3;
public AudioClip melodyE4;
public AudioClip melodyE5;
public AudioClip melodyE6;
public AudioClip melodyE7;
public AudioClip melodyE8;

public AudioClip accompanimentC1;
public AudioClip accompanimentC2;
public AudioClip accompanimentC3;

public AudioClip accompanimentE1;
public AudioClip accompanimentE2;
public AudioClip accompanimentE3;

public AudioClip bridgeCE;
public AudioClip bridgeCEShort;

public AudioClip bridgeEC;
public AudioClip bridgeECShort;
private Hv_UkuleleUnity_AudioLib _audio; //Heavy script

// Use this for initialization
void Start () {

_audio = GetComponent<Hv_UkuleleUnity_AudioLib> ();
        _audio.FillTableWithMonoAudioClip ("melodyC1", melodyC1); // fill arrays
        _audio.FillTableWithMonoAudioClip ("melodyC2", melodyC2);
        _audio.FillTableWithMonoAudioClip ("melodyC3", melodyC3);
        _audio.FillTableWithMonoAudioClip ("melodyC4", melodyC4);
        _audio.FillTableWithMonoAudioClip ("melodyC5", melodyC5);
        _audio.FillTableWithMonoAudioClip ("melodyC6", melodyC6);
        _audio.FillTableWithMonoAudioClip ("melodyC7", melodyC7);
        _audio.FillTableWithMonoAudioClip ("melodyC8", melodyC8);

        _audio.FillTableWithMonoAudioClip ("melodyE1", melodyE1);
        _audio.FillTableWithMonoAudioClip ("melodyE2", melodyE2);
        _audio.FillTableWithMonoAudioClip ("melodyE3", melodyE3);
        _audio.FillTableWithMonoAudioClip ("melodyE4", melodyE4);
        _audio.FillTableWithMonoAudioClip ("melodyE5", melodyE5);
        _audio.FillTableWithMonoAudioClip ("melodyE6", melodyE6);
        _audio.FillTableWithMonoAudioClip ("melodyE7", melodyE7);
        _audio.FillTableWithMonoAudioClip ("melodyE8", melodyE8);

        _audio.FillTableWithMonoAudioClip ("accompanimentC1", accompanimentC1);
        _audio.FillTableWithMonoAudioClip ("accompanimentC2", accompanimentC2);
        _audio.FillTableWithMonoAudioClip ("accompanimentC3", accompanimentC3);

        _audio.FillTableWithMonoAudioClip ("accompanimentE1", accompanimentE1);
        _audio.FillTableWithMonoAudioClip ("accompanimentE2", accompanimentE2);
        _audio.FillTableWithMonoAudioClip ("accompanimentE3", accompanimentE3);

        _audio.FillTableWithMonoAudioClip ("bridgeCE", bridgeCE);
        _audio.FillTableWithMonoAudioClip ("bridgeCES", bridgeCEShort);

        _audio.FillTableWithMonoAudioClip ("bridgeEC", bridgeEC);
        _audio.FillTableWithMonoAudioClip ("bridgeECS", bridgeECShort);

        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc1, melodyC1.samples); // send to pd sample length of every sound file
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc2, melodyC2.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc3, melodyC3.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc4, melodyC4.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc5, melodyC5.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc6, melodyC6.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc7, melodyC7.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc8, melodyC8.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc1,accompanimentC1.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc2, accompanimentC2.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc3, accompanimentC3.samples);

        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye1, melodyE1.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye2, melodyE2.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye3, melodyE3.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye4, melodyE4.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye5, melodyE5.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye6, melodyE6.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye7, melodyE7.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye8, melodyE8.samples);

        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente1, accompanimentE1.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente2, accompanimentE2.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente3, accompanimentE3.samples);

        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgece, bridgeCE.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeces, bridgeCEShort.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeec, bridgeEC.samples);
        _audio.SetFloatParameter (Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeecs, bridgeECShort.samples);



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
