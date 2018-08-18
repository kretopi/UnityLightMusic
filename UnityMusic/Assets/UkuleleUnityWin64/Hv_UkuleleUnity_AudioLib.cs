/**
 * Copyright (c) 2018 Enzien Audio, Ltd.
 * 
 * Redistribution and use in source and binary forms, with or without modification,
 * are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice,
 *    this list of conditions, and the following disclaimer.
 * 
 * 2. Redistributions in binary form must reproduce the phrase "powered by heavy",
 *    the heavy logo, and a hyperlink to https://enzienaudio.com, all in a visible
 *    form.
 * 
 *   2.1 If the Application is distributed in a store system (for example,
 *       the Apple "App Store" or "Google Play"), the phrase "powered by heavy"
 *       shall be included in the app description or the copyright text as well as
 *       the in the app itself. The heavy logo will shall be visible in the app
 *       itself as well.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO,
 * THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
 * FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
 * OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 */

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
using AOT;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(Hv_UkuleleUnity_AudioLib))]
public class Hv_UkuleleUnity_Editor : Editor {

  [MenuItem("Heavy/UkuleleUnity")]
  static void CreateHv_UkuleleUnity() {
    GameObject target = Selection.activeGameObject;
    if (target != null) {
      target.AddComponent<Hv_UkuleleUnity_AudioLib>();
    }
  }
  
  private Hv_UkuleleUnity_AudioLib _dsp;

  private void OnEnable() {
    _dsp = target as Hv_UkuleleUnity_AudioLib;
  }

  public override void OnInspectorGUI() {
    bool isEnabled = _dsp.IsInstantiated();
    if (!isEnabled) {
      EditorGUILayout.LabelField("Press Play!",  EditorStyles.centeredGreyMiniLabel);
    }
    // events
    GUI.enabled = isEnabled;
    EditorGUILayout.Space();
    // C
    if (GUILayout.Button("C")) {
      _dsp.SendEvent(Hv_UkuleleUnity_AudioLib.Event.C);
    }
    
    // E
    if (GUILayout.Button("E")) {
      _dsp.SendEvent(Hv_UkuleleUnity_AudioLib.Event.E);
    }
    
    // Play
    if (GUILayout.Button("Play")) {
      _dsp.SendEvent(Hv_UkuleleUnity_AudioLib.Event.Play);
    }
    
    // Stop
    if (GUILayout.Button("Stop")) {
      _dsp.SendEvent(Hv_UkuleleUnity_AudioLib.Event.Stop);
    }
    
    GUILayout.EndVertical();

    // parameters
    GUI.enabled = true;
    GUILayout.BeginVertical();
    EditorGUILayout.Space();
    EditorGUI.indentLevel++;
    
    // sampleAccompanimentC1
    GUILayout.BeginHorizontal();
    float sampleAccompanimentC1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc1);
    float newSampleaccompanimentc1 = EditorGUILayout.Slider("sampleAccompanimentC1", sampleAccompanimentC1, 0.0f, 441000.0f);
    if (sampleAccompanimentC1 != newSampleaccompanimentc1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc1, newSampleaccompanimentc1);
    }
    GUILayout.EndHorizontal();
    
    // sampleAccompanimentC2
    GUILayout.BeginHorizontal();
    float sampleAccompanimentC2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc2);
    float newSampleaccompanimentc2 = EditorGUILayout.Slider("sampleAccompanimentC2", sampleAccompanimentC2, 0.0f, 441000.0f);
    if (sampleAccompanimentC2 != newSampleaccompanimentc2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc2, newSampleaccompanimentc2);
    }
    GUILayout.EndHorizontal();
    
    // sampleAccompanimentC3
    GUILayout.BeginHorizontal();
    float sampleAccompanimentC3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc3);
    float newSampleaccompanimentc3 = EditorGUILayout.Slider("sampleAccompanimentC3", sampleAccompanimentC3, 0.0f, 441000.0f);
    if (sampleAccompanimentC3 != newSampleaccompanimentc3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc3, newSampleaccompanimentc3);
    }
    GUILayout.EndHorizontal();
    
    // sampleAccompanimentE1
    GUILayout.BeginHorizontal();
    float sampleAccompanimentE1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente1);
    float newSampleaccompanimente1 = EditorGUILayout.Slider("sampleAccompanimentE1", sampleAccompanimentE1, 0.0f, 441000.0f);
    if (sampleAccompanimentE1 != newSampleaccompanimente1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente1, newSampleaccompanimente1);
    }
    GUILayout.EndHorizontal();
    
    // sampleAccompanimentE2
    GUILayout.BeginHorizontal();
    float sampleAccompanimentE2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente2);
    float newSampleaccompanimente2 = EditorGUILayout.Slider("sampleAccompanimentE2", sampleAccompanimentE2, 0.0f, 441000.0f);
    if (sampleAccompanimentE2 != newSampleaccompanimente2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente2, newSampleaccompanimente2);
    }
    GUILayout.EndHorizontal();
    
    // sampleAccompanimentE3
    GUILayout.BeginHorizontal();
    float sampleAccompanimentE3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente3);
    float newSampleaccompanimente3 = EditorGUILayout.Slider("sampleAccompanimentE3", sampleAccompanimentE3, 0.0f, 441000.0f);
    if (sampleAccompanimentE3 != newSampleaccompanimente3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimente3, newSampleaccompanimente3);
    }
    GUILayout.EndHorizontal();
    
    // sampleBridgeCE
    GUILayout.BeginHorizontal();
    float sampleBridgeCE = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgece);
    float newSamplebridgece = EditorGUILayout.Slider("sampleBridgeCE", sampleBridgeCE, 0.0f, 441000.0f);
    if (sampleBridgeCE != newSamplebridgece) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgece, newSamplebridgece);
    }
    GUILayout.EndHorizontal();
    
    // sampleBridgeCES
    GUILayout.BeginHorizontal();
    float sampleBridgeCES = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeces);
    float newSamplebridgeces = EditorGUILayout.Slider("sampleBridgeCES", sampleBridgeCES, 0.0f, 441000.0f);
    if (sampleBridgeCES != newSamplebridgeces) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeces, newSamplebridgeces);
    }
    GUILayout.EndHorizontal();
    
    // sampleBridgeEC
    GUILayout.BeginHorizontal();
    float sampleBridgeEC = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeec);
    float newSamplebridgeec = EditorGUILayout.Slider("sampleBridgeEC", sampleBridgeEC, 0.0f, 441000.0f);
    if (sampleBridgeEC != newSamplebridgeec) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeec, newSamplebridgeec);
    }
    GUILayout.EndHorizontal();
    
    // sampleBridgeECS
    GUILayout.BeginHorizontal();
    float sampleBridgeECS = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeecs);
    float newSamplebridgeecs = EditorGUILayout.Slider("sampleBridgeECS", sampleBridgeECS, 0.0f, 441000.0f);
    if (sampleBridgeECS != newSamplebridgeecs) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplebridgeecs, newSamplebridgeecs);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC1
    GUILayout.BeginHorizontal();
    float sampleMelodyC1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc1);
    float newSamplemelodyc1 = EditorGUILayout.Slider("sampleMelodyC1", sampleMelodyC1, 0.0f, 441000.0f);
    if (sampleMelodyC1 != newSamplemelodyc1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc1, newSamplemelodyc1);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC2
    GUILayout.BeginHorizontal();
    float sampleMelodyC2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc2);
    float newSamplemelodyc2 = EditorGUILayout.Slider("sampleMelodyC2", sampleMelodyC2, 0.0f, 441000.0f);
    if (sampleMelodyC2 != newSamplemelodyc2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc2, newSamplemelodyc2);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC3
    GUILayout.BeginHorizontal();
    float sampleMelodyC3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc3);
    float newSamplemelodyc3 = EditorGUILayout.Slider("sampleMelodyC3", sampleMelodyC3, 0.0f, 441000.0f);
    if (sampleMelodyC3 != newSamplemelodyc3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc3, newSamplemelodyc3);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC4
    GUILayout.BeginHorizontal();
    float sampleMelodyC4 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc4);
    float newSamplemelodyc4 = EditorGUILayout.Slider("sampleMelodyC4", sampleMelodyC4, 0.0f, 441000.0f);
    if (sampleMelodyC4 != newSamplemelodyc4) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc4, newSamplemelodyc4);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC5
    GUILayout.BeginHorizontal();
    float sampleMelodyC5 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc5);
    float newSamplemelodyc5 = EditorGUILayout.Slider("sampleMelodyC5", sampleMelodyC5, 0.0f, 441000.0f);
    if (sampleMelodyC5 != newSamplemelodyc5) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc5, newSamplemelodyc5);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC6
    GUILayout.BeginHorizontal();
    float sampleMelodyC6 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc6);
    float newSamplemelodyc6 = EditorGUILayout.Slider("sampleMelodyC6", sampleMelodyC6, 0.0f, 441000.0f);
    if (sampleMelodyC6 != newSamplemelodyc6) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc6, newSamplemelodyc6);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC7
    GUILayout.BeginHorizontal();
    float sampleMelodyC7 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc7);
    float newSamplemelodyc7 = EditorGUILayout.Slider("sampleMelodyC7", sampleMelodyC7, 0.0f, 441000.0f);
    if (sampleMelodyC7 != newSamplemelodyc7) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc7, newSamplemelodyc7);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyC8
    GUILayout.BeginHorizontal();
    float sampleMelodyC8 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc8);
    float newSamplemelodyc8 = EditorGUILayout.Slider("sampleMelodyC8", sampleMelodyC8, 0.0f, 441000.0f);
    if (sampleMelodyC8 != newSamplemelodyc8) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodyc8, newSamplemelodyc8);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE1
    GUILayout.BeginHorizontal();
    float sampleMelodyE1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye1);
    float newSamplemelodye1 = EditorGUILayout.Slider("sampleMelodyE1", sampleMelodyE1, 0.0f, 441000.0f);
    if (sampleMelodyE1 != newSamplemelodye1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye1, newSamplemelodye1);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE2
    GUILayout.BeginHorizontal();
    float sampleMelodyE2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye2);
    float newSamplemelodye2 = EditorGUILayout.Slider("sampleMelodyE2", sampleMelodyE2, 0.0f, 44100.0f);
    if (sampleMelodyE2 != newSamplemelodye2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye2, newSamplemelodye2);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE3
    GUILayout.BeginHorizontal();
    float sampleMelodyE3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye3);
    float newSamplemelodye3 = EditorGUILayout.Slider("sampleMelodyE3", sampleMelodyE3, 0.0f, 441000.0f);
    if (sampleMelodyE3 != newSamplemelodye3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye3, newSamplemelodye3);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE4
    GUILayout.BeginHorizontal();
    float sampleMelodyE4 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye4);
    float newSamplemelodye4 = EditorGUILayout.Slider("sampleMelodyE4", sampleMelodyE4, 0.0f, 441000.0f);
    if (sampleMelodyE4 != newSamplemelodye4) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye4, newSamplemelodye4);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE5
    GUILayout.BeginHorizontal();
    float sampleMelodyE5 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye5);
    float newSamplemelodye5 = EditorGUILayout.Slider("sampleMelodyE5", sampleMelodyE5, 0.0f, 441000.0f);
    if (sampleMelodyE5 != newSamplemelodye5) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye5, newSamplemelodye5);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE6
    GUILayout.BeginHorizontal();
    float sampleMelodyE6 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye6);
    float newSamplemelodye6 = EditorGUILayout.Slider("sampleMelodyE6", sampleMelodyE6, 0.0f, 441000.0f);
    if (sampleMelodyE6 != newSamplemelodye6) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye6, newSamplemelodye6);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE7
    GUILayout.BeginHorizontal();
    float sampleMelodyE7 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye7);
    float newSamplemelodye7 = EditorGUILayout.Slider("sampleMelodyE7", sampleMelodyE7, 0.0f, 441000.0f);
    if (sampleMelodyE7 != newSamplemelodye7) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye7, newSamplemelodye7);
    }
    GUILayout.EndHorizontal();
    
    // sampleMelodyE8
    GUILayout.BeginHorizontal();
    float sampleMelodyE8 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye8);
    float newSamplemelodye8 = EditorGUILayout.Slider("sampleMelodyE8", sampleMelodyE8, 0.0f, 441000.0f);
    if (sampleMelodyE8 != newSamplemelodye8) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Samplemelodye8, newSamplemelodye8);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentC1
    GUILayout.BeginHorizontal();
    float volAccompanimentC1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc1);
    float newVolaccompanimentc1 = EditorGUILayout.Slider("volAccompanimentC1", volAccompanimentC1, 0.0f, 2.0f);
    if (volAccompanimentC1 != newVolaccompanimentc1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc1, newVolaccompanimentc1);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentC2
    GUILayout.BeginHorizontal();
    float volAccompanimentC2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc2);
    float newVolaccompanimentc2 = EditorGUILayout.Slider("volAccompanimentC2", volAccompanimentC2, 0.0f, 2.0f);
    if (volAccompanimentC2 != newVolaccompanimentc2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc2, newVolaccompanimentc2);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentC3
    GUILayout.BeginHorizontal();
    float volAccompanimentC3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc3);
    float newVolaccompanimentc3 = EditorGUILayout.Slider("volAccompanimentC3", volAccompanimentC3, 0.0f, 2.0f);
    if (volAccompanimentC3 != newVolaccompanimentc3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimentc3, newVolaccompanimentc3);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentE1
    GUILayout.BeginHorizontal();
    float volAccompanimentE1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente1);
    float newVolaccompanimente1 = EditorGUILayout.Slider("volAccompanimentE1", volAccompanimentE1, 0.0f, 2.0f);
    if (volAccompanimentE1 != newVolaccompanimente1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente1, newVolaccompanimente1);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentE2
    GUILayout.BeginHorizontal();
    float volAccompanimentE2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente2);
    float newVolaccompanimente2 = EditorGUILayout.Slider("volAccompanimentE2", volAccompanimentE2, 0.0f, 2.0f);
    if (volAccompanimentE2 != newVolaccompanimente2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente2, newVolaccompanimente2);
    }
    GUILayout.EndHorizontal();
    
    // volAccompanimentE3
    GUILayout.BeginHorizontal();
    float volAccompanimentE3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente3);
    float newVolaccompanimente3 = EditorGUILayout.Slider("volAccompanimentE3", volAccompanimentE3, 0.0f, 2.0f);
    if (volAccompanimentE3 != newVolaccompanimente3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volaccompanimente3, newVolaccompanimente3);
    }
    GUILayout.EndHorizontal();
    
    // volBridgeCE
    GUILayout.BeginHorizontal();
    float volBridgeCE = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgece);
    float newVolbridgece = EditorGUILayout.Slider("volBridgeCE", volBridgeCE, 0.0f, 2.0f);
    if (volBridgeCE != newVolbridgece) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgece, newVolbridgece);
    }
    GUILayout.EndHorizontal();
    
    // volBridgeCES
    GUILayout.BeginHorizontal();
    float volBridgeCES = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeces);
    float newVolbridgeces = EditorGUILayout.Slider("volBridgeCES", volBridgeCES, 0.0f, 2.0f);
    if (volBridgeCES != newVolbridgeces) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeces, newVolbridgeces);
    }
    GUILayout.EndHorizontal();
    
    // volBridgeEC
    GUILayout.BeginHorizontal();
    float volBridgeEC = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeec);
    float newVolbridgeec = EditorGUILayout.Slider("volBridgeEC", volBridgeEC, 0.0f, 2.0f);
    if (volBridgeEC != newVolbridgeec) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeec, newVolbridgeec);
    }
    GUILayout.EndHorizontal();
    
    // volBridgeECS
    GUILayout.BeginHorizontal();
    float volBridgeECS = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeecs);
    float newVolbridgeecs = EditorGUILayout.Slider("volBridgeECS", volBridgeECS, 0.0f, 2.0f);
    if (volBridgeECS != newVolbridgeecs) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volbridgeecs, newVolbridgeecs);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC1
    GUILayout.BeginHorizontal();
    float volMelodyC1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc1);
    float newVolmelodyc1 = EditorGUILayout.Slider("volMelodyC1", volMelodyC1, 0.0f, 2.0f);
    if (volMelodyC1 != newVolmelodyc1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc1, newVolmelodyc1);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC2
    GUILayout.BeginHorizontal();
    float volMelodyC2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc2);
    float newVolmelodyc2 = EditorGUILayout.Slider("volMelodyC2", volMelodyC2, 0.0f, 2.0f);
    if (volMelodyC2 != newVolmelodyc2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc2, newVolmelodyc2);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC3
    GUILayout.BeginHorizontal();
    float volMelodyC3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc3);
    float newVolmelodyc3 = EditorGUILayout.Slider("volMelodyC3", volMelodyC3, 0.0f, 2.0f);
    if (volMelodyC3 != newVolmelodyc3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc3, newVolmelodyc3);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC4
    GUILayout.BeginHorizontal();
    float volMelodyC4 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc4);
    float newVolmelodyc4 = EditorGUILayout.Slider("volMelodyC4", volMelodyC4, 0.0f, 2.0f);
    if (volMelodyC4 != newVolmelodyc4) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc4, newVolmelodyc4);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC5
    GUILayout.BeginHorizontal();
    float volMelodyC5 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc5);
    float newVolmelodyc5 = EditorGUILayout.Slider("volMelodyC5", volMelodyC5, 0.0f, 2.0f);
    if (volMelodyC5 != newVolmelodyc5) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc5, newVolmelodyc5);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC6
    GUILayout.BeginHorizontal();
    float volMelodyC6 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc6);
    float newVolmelodyc6 = EditorGUILayout.Slider("volMelodyC6", volMelodyC6, 0.0f, 2.0f);
    if (volMelodyC6 != newVolmelodyc6) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc6, newVolmelodyc6);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC7
    GUILayout.BeginHorizontal();
    float volMelodyC7 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc7);
    float newVolmelodyc7 = EditorGUILayout.Slider("volMelodyC7", volMelodyC7, 0.0f, 2.0f);
    if (volMelodyC7 != newVolmelodyc7) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc7, newVolmelodyc7);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyC8
    GUILayout.BeginHorizontal();
    float volMelodyC8 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc8);
    float newVolmelodyc8 = EditorGUILayout.Slider("volMelodyC8", volMelodyC8, 0.0f, 2.0f);
    if (volMelodyC8 != newVolmelodyc8) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodyc8, newVolmelodyc8);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE1
    GUILayout.BeginHorizontal();
    float volMelodyE1 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye1);
    float newVolmelodye1 = EditorGUILayout.Slider("volMelodyE1", volMelodyE1, 0.0f, 2.0f);
    if (volMelodyE1 != newVolmelodye1) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye1, newVolmelodye1);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE2
    GUILayout.BeginHorizontal();
    float volMelodyE2 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye2);
    float newVolmelodye2 = EditorGUILayout.Slider("volMelodyE2", volMelodyE2, 0.0f, 2.0f);
    if (volMelodyE2 != newVolmelodye2) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye2, newVolmelodye2);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE3
    GUILayout.BeginHorizontal();
    float volMelodyE3 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye3);
    float newVolmelodye3 = EditorGUILayout.Slider("volMelodyE3", volMelodyE3, 0.0f, 2.0f);
    if (volMelodyE3 != newVolmelodye3) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye3, newVolmelodye3);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE4
    GUILayout.BeginHorizontal();
    float volMelodyE4 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye4);
    float newVolmelodye4 = EditorGUILayout.Slider("volMelodyE4", volMelodyE4, 0.0f, 2.0f);
    if (volMelodyE4 != newVolmelodye4) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye4, newVolmelodye4);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE5
    GUILayout.BeginHorizontal();
    float volMelodyE5 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye5);
    float newVolmelodye5 = EditorGUILayout.Slider("volMelodyE5", volMelodyE5, 0.0f, 2.0f);
    if (volMelodyE5 != newVolmelodye5) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye5, newVolmelodye5);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE6
    GUILayout.BeginHorizontal();
    float volMelodyE6 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye6);
    float newVolmelodye6 = EditorGUILayout.Slider("volMelodyE6", volMelodyE6, 0.0f, 2.0f);
    if (volMelodyE6 != newVolmelodye6) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye6, newVolmelodye6);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE7
    GUILayout.BeginHorizontal();
    float volMelodyE7 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye7);
    float newVolmelodye7 = EditorGUILayout.Slider("volMelodyE7", volMelodyE7, 0.0f, 2.0f);
    if (volMelodyE7 != newVolmelodye7) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye7, newVolmelodye7);
    }
    GUILayout.EndHorizontal();
    
    // volMelodyE8
    GUILayout.BeginHorizontal();
    float volMelodyE8 = _dsp.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye8);
    float newVolmelodye8 = EditorGUILayout.Slider("volMelodyE8", volMelodyE8, 0.0f, 2.0f);
    if (volMelodyE8 != newVolmelodye8) {
      _dsp.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Volmelodye8, newVolmelodye8);
    }
    GUILayout.EndHorizontal();
    EditorGUI.indentLevel--;
  }
}
#endif // UNITY_EDITOR

[RequireComponent (typeof (AudioSource))]
public class Hv_UkuleleUnity_AudioLib : MonoBehaviour {
  
  // Events are used to trigger bangs in the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
        script.SendEvent(Hv_UkuleleUnity_AudioLib.Event.C);
    }
  */
  public enum Event : uint {
    C = 0x7F1A5B02,
    E = 0x48BA38A1,
    Play = 0x82489465,
    Stop = 0x2842784A,
  }
  
  // Parameters are used to send float messages into the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
        // Get and set a parameter
        float sampleAccompanimentC1 = script.GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc1);
        script.SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter.Sampleaccompanimentc1, sampleAccompanimentC1 + 0.1f);
    }
  */
  public enum Parameter : uint {
    Sampleaccompanimentc1 = 0x3F0862F1,
    Sampleaccompanimentc2 = 0x94C7DDD7,
    Sampleaccompanimentc3 = 0xB47A940F,
    Sampleaccompanimente1 = 0x1F1ADAEB,
    Sampleaccompanimente2 = 0xA854AE44,
    Sampleaccompanimente3 = 0x363FA0F4,
    Samplebridgece = 0x1FB69F31,
    Samplebridgeces = 0x5126DCF0,
    Samplebridgeec = 0x4EF8B1E,
    Samplebridgeecs = 0xEAC83C2,
    Samplemelodyc1 = 0xB65D9C55,
    Samplemelodyc2 = 0x7CE83BB1,
    Samplemelodyc3 = 0x20D483E6,
    Samplemelodyc4 = 0x5A0E6863,
    Samplemelodyc5 = 0x5454963A,
    Samplemelodyc6 = 0x347916F3,
    Samplemelodyc7 = 0x2007ABEF,
    Samplemelodyc8 = 0x4F2881D6,
    Samplemelodye1 = 0xA65B301C,
    Samplemelodye2 = 0xFCED2E7A,
    Samplemelodye3 = 0x4451987D,
    Samplemelodye4 = 0xF1D0D824,
    Samplemelodye5 = 0x27C84011,
    Samplemelodye6 = 0x9970CE5E,
    Samplemelodye7 = 0x2F89B677,
    Samplemelodye8 = 0x2172B5EB,
    Volaccompanimentc1 = 0x5769B660,
    Volaccompanimentc2 = 0x3B5BFEB4,
    Volaccompanimentc3 = 0x9B03677B,
    Volaccompanimente1 = 0x48F671F5,
    Volaccompanimente2 = 0x245145D3,
    Volaccompanimente3 = 0xF8D4E49F,
    Volbridgece = 0x9826466F,
    Volbridgeces = 0x94045A6,
    Volbridgeec = 0x3AB0FD0C,
    Volbridgeecs = 0xD6F390A6,
    Volmelodyc1 = 0xA32B2D74,
    Volmelodyc2 = 0x2C0A439,
    Volmelodyc3 = 0xE9A4D27A,
    Volmelodyc4 = 0x818C2B9,
    Volmelodyc5 = 0x5A46898C,
    Volmelodyc6 = 0xE6B3BEFC,
    Volmelodyc7 = 0x30A9B243,
    Volmelodyc8 = 0xDF071A65,
    Volmelodye1 = 0x4EA43C34,
    Volmelodye2 = 0xEEEBEB01,
    Volmelodye3 = 0x48D0F32D,
    Volmelodye4 = 0x378C18FD,
    Volmelodye5 = 0xADBC2427,
    Volmelodye6 = 0x3FC61B39,
    Volmelodye7 = 0x26F74C83,
    Volmelodye8 = 0x12ABC392,
  }
  
  // Delegate method for receiving float messages from the patch context (thread-safe).
  // Example usage:
  /*
    void Start () {
        Hv_UkuleleUnity_AudioLib script = GetComponent<Hv_UkuleleUnity_AudioLib>();
        script.RegisterSendHook();
        script.FloatReceivedCallback += OnFloatMessage;
    }

    void OnFloatMessage(Hv_UkuleleUnity_AudioLib.FloatMessage message) {
        Debug.Log(message.receiverName + ": " + message.value);
    }
  */
  public class FloatMessage {
    public string receiverName;
    public float value;

    public FloatMessage(string name, float x) {
      receiverName = name;
      value = x;
    }
  }
  public delegate void FloatMessageReceived(FloatMessage message);
  public FloatMessageReceived FloatReceivedCallback;
  public float sampleAccompanimentC1 = 0.0f;
  public float sampleAccompanimentC2 = 0.0f;
  public float sampleAccompanimentC3 = 0.0f;
  public float sampleAccompanimentE1 = 0.0f;
  public float sampleAccompanimentE2 = 0.0f;
  public float sampleAccompanimentE3 = 0.0f;
  public float sampleBridgeCE = 0.0f;
  public float sampleBridgeCES = 0.0f;
  public float sampleBridgeEC = 0.0f;
  public float sampleBridgeECS = 0.0f;
  public float sampleMelodyC1 = 0.0f;
  public float sampleMelodyC2 = 0.0f;
  public float sampleMelodyC3 = 0.0f;
  public float sampleMelodyC4 = 0.0f;
  public float sampleMelodyC5 = 0.0f;
  public float sampleMelodyC6 = 0.0f;
  public float sampleMelodyC7 = 0.0f;
  public float sampleMelodyC8 = 0.0f;
  public float sampleMelodyE1 = 0.0f;
  public float sampleMelodyE2 = 0.0f;
  public float sampleMelodyE3 = 0.0f;
  public float sampleMelodyE4 = 0.0f;
  public float sampleMelodyE5 = 0.0f;
  public float sampleMelodyE6 = 0.0f;
  public float sampleMelodyE7 = 0.0f;
  public float sampleMelodyE8 = 0.0f;
  public float volAccompanimentC1 = 1.0f;
  public float volAccompanimentC2 = 1.0f;
  public float volAccompanimentC3 = 1.0f;
  public float volAccompanimentE1 = 1.0f;
  public float volAccompanimentE2 = 1.0f;
  public float volAccompanimentE3 = 1.0f;
  public float volBridgeCE = 1.0f;
  public float volBridgeCES = 1.0f;
  public float volBridgeEC = 1.0f;
  public float volBridgeECS = 1.0f;
  public float volMelodyC1 = 1.0f;
  public float volMelodyC2 = 1.0f;
  public float volMelodyC3 = 1.0f;
  public float volMelodyC4 = 1.0f;
  public float volMelodyC5 = 1.0f;
  public float volMelodyC6 = 1.0f;
  public float volMelodyC7 = 1.0f;
  public float volMelodyC8 = 1.0f;
  public float volMelodyE1 = 1.0f;
  public float volMelodyE2 = 1.0f;
  public float volMelodyE3 = 1.0f;
  public float volMelodyE4 = 1.0f;
  public float volMelodyE5 = 1.0f;
  public float volMelodyE6 = 1.0f;
  public float volMelodyE7 = 1.0f;
  public float volMelodyE8 = 1.0f;

  // internal state
  private Hv_UkuleleUnity_Context _context;

  public bool IsInstantiated() {
    return (_context != null);
  }

  public void RegisterSendHook() {
    _context.RegisterSendHook();
  }
  
  // see Hv_UkuleleUnity_AudioLib.Event for definitions
  public void SendEvent(Hv_UkuleleUnity_AudioLib.Event e) {
    if (IsInstantiated()) _context.SendBangToReceiver((uint) e);
  }
  
  // see Hv_UkuleleUnity_AudioLib.Parameter for definitions
  public float GetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter param) {
    switch (param) {
      case Parameter.Sampleaccompanimentc1: return sampleAccompanimentC1;
      case Parameter.Sampleaccompanimentc2: return sampleAccompanimentC2;
      case Parameter.Sampleaccompanimentc3: return sampleAccompanimentC3;
      case Parameter.Sampleaccompanimente1: return sampleAccompanimentE1;
      case Parameter.Sampleaccompanimente2: return sampleAccompanimentE2;
      case Parameter.Sampleaccompanimente3: return sampleAccompanimentE3;
      case Parameter.Samplebridgece: return sampleBridgeCE;
      case Parameter.Samplebridgeces: return sampleBridgeCES;
      case Parameter.Samplebridgeec: return sampleBridgeEC;
      case Parameter.Samplebridgeecs: return sampleBridgeECS;
      case Parameter.Samplemelodyc1: return sampleMelodyC1;
      case Parameter.Samplemelodyc2: return sampleMelodyC2;
      case Parameter.Samplemelodyc3: return sampleMelodyC3;
      case Parameter.Samplemelodyc4: return sampleMelodyC4;
      case Parameter.Samplemelodyc5: return sampleMelodyC5;
      case Parameter.Samplemelodyc6: return sampleMelodyC6;
      case Parameter.Samplemelodyc7: return sampleMelodyC7;
      case Parameter.Samplemelodyc8: return sampleMelodyC8;
      case Parameter.Samplemelodye1: return sampleMelodyE1;
      case Parameter.Samplemelodye2: return sampleMelodyE2;
      case Parameter.Samplemelodye3: return sampleMelodyE3;
      case Parameter.Samplemelodye4: return sampleMelodyE4;
      case Parameter.Samplemelodye5: return sampleMelodyE5;
      case Parameter.Samplemelodye6: return sampleMelodyE6;
      case Parameter.Samplemelodye7: return sampleMelodyE7;
      case Parameter.Samplemelodye8: return sampleMelodyE8;
      case Parameter.Volaccompanimentc1: return volAccompanimentC1;
      case Parameter.Volaccompanimentc2: return volAccompanimentC2;
      case Parameter.Volaccompanimentc3: return volAccompanimentC3;
      case Parameter.Volaccompanimente1: return volAccompanimentE1;
      case Parameter.Volaccompanimente2: return volAccompanimentE2;
      case Parameter.Volaccompanimente3: return volAccompanimentE3;
      case Parameter.Volbridgece: return volBridgeCE;
      case Parameter.Volbridgeces: return volBridgeCES;
      case Parameter.Volbridgeec: return volBridgeEC;
      case Parameter.Volbridgeecs: return volBridgeECS;
      case Parameter.Volmelodyc1: return volMelodyC1;
      case Parameter.Volmelodyc2: return volMelodyC2;
      case Parameter.Volmelodyc3: return volMelodyC3;
      case Parameter.Volmelodyc4: return volMelodyC4;
      case Parameter.Volmelodyc5: return volMelodyC5;
      case Parameter.Volmelodyc6: return volMelodyC6;
      case Parameter.Volmelodyc7: return volMelodyC7;
      case Parameter.Volmelodyc8: return volMelodyC8;
      case Parameter.Volmelodye1: return volMelodyE1;
      case Parameter.Volmelodye2: return volMelodyE2;
      case Parameter.Volmelodye3: return volMelodyE3;
      case Parameter.Volmelodye4: return volMelodyE4;
      case Parameter.Volmelodye5: return volMelodyE5;
      case Parameter.Volmelodye6: return volMelodyE6;
      case Parameter.Volmelodye7: return volMelodyE7;
      case Parameter.Volmelodye8: return volMelodyE8;
      default: return 0.0f;
    }
  }

  public void SetFloatParameter(Hv_UkuleleUnity_AudioLib.Parameter param, float x) {
    switch (param) {
      case Parameter.Sampleaccompanimentc1: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentC1 = x;
        break;
      }
      case Parameter.Sampleaccompanimentc2: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentC2 = x;
        break;
      }
      case Parameter.Sampleaccompanimentc3: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentC3 = x;
        break;
      }
      case Parameter.Sampleaccompanimente1: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentE1 = x;
        break;
      }
      case Parameter.Sampleaccompanimente2: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentE2 = x;
        break;
      }
      case Parameter.Sampleaccompanimente3: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleAccompanimentE3 = x;
        break;
      }
      case Parameter.Samplebridgece: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleBridgeCE = x;
        break;
      }
      case Parameter.Samplebridgeces: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleBridgeCES = x;
        break;
      }
      case Parameter.Samplebridgeec: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleBridgeEC = x;
        break;
      }
      case Parameter.Samplebridgeecs: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleBridgeECS = x;
        break;
      }
      case Parameter.Samplemelodyc1: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC1 = x;
        break;
      }
      case Parameter.Samplemelodyc2: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC2 = x;
        break;
      }
      case Parameter.Samplemelodyc3: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC3 = x;
        break;
      }
      case Parameter.Samplemelodyc4: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC4 = x;
        break;
      }
      case Parameter.Samplemelodyc5: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC5 = x;
        break;
      }
      case Parameter.Samplemelodyc6: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC6 = x;
        break;
      }
      case Parameter.Samplemelodyc7: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC7 = x;
        break;
      }
      case Parameter.Samplemelodyc8: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyC8 = x;
        break;
      }
      case Parameter.Samplemelodye1: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE1 = x;
        break;
      }
      case Parameter.Samplemelodye2: {
        x = Mathf.Clamp(x, 0.0f, 44100.0f);
        sampleMelodyE2 = x;
        break;
      }
      case Parameter.Samplemelodye3: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE3 = x;
        break;
      }
      case Parameter.Samplemelodye4: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE4 = x;
        break;
      }
      case Parameter.Samplemelodye5: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE5 = x;
        break;
      }
      case Parameter.Samplemelodye6: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE6 = x;
        break;
      }
      case Parameter.Samplemelodye7: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE7 = x;
        break;
      }
      case Parameter.Samplemelodye8: {
        x = Mathf.Clamp(x, 0.0f, 441000.0f);
        sampleMelodyE8 = x;
        break;
      }
      case Parameter.Volaccompanimentc1: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentC1 = x;
        break;
      }
      case Parameter.Volaccompanimentc2: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentC2 = x;
        break;
      }
      case Parameter.Volaccompanimentc3: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentC3 = x;
        break;
      }
      case Parameter.Volaccompanimente1: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentE1 = x;
        break;
      }
      case Parameter.Volaccompanimente2: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentE2 = x;
        break;
      }
      case Parameter.Volaccompanimente3: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volAccompanimentE3 = x;
        break;
      }
      case Parameter.Volbridgece: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volBridgeCE = x;
        break;
      }
      case Parameter.Volbridgeces: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volBridgeCES = x;
        break;
      }
      case Parameter.Volbridgeec: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volBridgeEC = x;
        break;
      }
      case Parameter.Volbridgeecs: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volBridgeECS = x;
        break;
      }
      case Parameter.Volmelodyc1: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC1 = x;
        break;
      }
      case Parameter.Volmelodyc2: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC2 = x;
        break;
      }
      case Parameter.Volmelodyc3: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC3 = x;
        break;
      }
      case Parameter.Volmelodyc4: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC4 = x;
        break;
      }
      case Parameter.Volmelodyc5: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC5 = x;
        break;
      }
      case Parameter.Volmelodyc6: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC6 = x;
        break;
      }
      case Parameter.Volmelodyc7: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC7 = x;
        break;
      }
      case Parameter.Volmelodyc8: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyC8 = x;
        break;
      }
      case Parameter.Volmelodye1: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE1 = x;
        break;
      }
      case Parameter.Volmelodye2: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE2 = x;
        break;
      }
      case Parameter.Volmelodye3: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE3 = x;
        break;
      }
      case Parameter.Volmelodye4: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE4 = x;
        break;
      }
      case Parameter.Volmelodye5: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE5 = x;
        break;
      }
      case Parameter.Volmelodye6: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE6 = x;
        break;
      }
      case Parameter.Volmelodye7: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE7 = x;
        break;
      }
      case Parameter.Volmelodye8: {
        x = Mathf.Clamp(x, 0.0f, 2.0f);
        volMelodyE8 = x;
        break;
      }
      default: return;
    }
    if (IsInstantiated()) _context.SendFloatToReceiver((uint) param, x);
  }
  
  public void FillTableWithMonoAudioClip(string tableName, AudioClip clip) {
    if (clip.channels > 1) {
      Debug.LogWarning("Hv_UkuleleUnity_AudioLib: Only loading first channel of '" +
          clip.name + "' into table '" +
          tableName + "'. Multi-channel files are not supported.");
    }
    float[] buffer = new float[clip.samples]; // copy only the 1st channel
    clip.GetData(buffer, 0);
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    _context.FillTableWithFloatBuffer(tableName, buffer);
  }

  private void Awake() {
    _context = new Hv_UkuleleUnity_Context((double) AudioSettings.outputSampleRate);
  }
  
  private void Start() {
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimentc1, sampleAccompanimentC1);
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimentc2, sampleAccompanimentC2);
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimentc3, sampleAccompanimentC3);
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimente1, sampleAccompanimentE1);
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimente2, sampleAccompanimentE2);
    _context.SendFloatToReceiver((uint) Parameter.Sampleaccompanimente3, sampleAccompanimentE3);
    _context.SendFloatToReceiver((uint) Parameter.Samplebridgece, sampleBridgeCE);
    _context.SendFloatToReceiver((uint) Parameter.Samplebridgeces, sampleBridgeCES);
    _context.SendFloatToReceiver((uint) Parameter.Samplebridgeec, sampleBridgeEC);
    _context.SendFloatToReceiver((uint) Parameter.Samplebridgeecs, sampleBridgeECS);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc1, sampleMelodyC1);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc2, sampleMelodyC2);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc3, sampleMelodyC3);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc4, sampleMelodyC4);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc5, sampleMelodyC5);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc6, sampleMelodyC6);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc7, sampleMelodyC7);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodyc8, sampleMelodyC8);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye1, sampleMelodyE1);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye2, sampleMelodyE2);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye3, sampleMelodyE3);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye4, sampleMelodyE4);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye5, sampleMelodyE5);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye6, sampleMelodyE6);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye7, sampleMelodyE7);
    _context.SendFloatToReceiver((uint) Parameter.Samplemelodye8, sampleMelodyE8);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimentc1, volAccompanimentC1);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimentc2, volAccompanimentC2);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimentc3, volAccompanimentC3);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimente1, volAccompanimentE1);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimente2, volAccompanimentE2);
    _context.SendFloatToReceiver((uint) Parameter.Volaccompanimente3, volAccompanimentE3);
    _context.SendFloatToReceiver((uint) Parameter.Volbridgece, volBridgeCE);
    _context.SendFloatToReceiver((uint) Parameter.Volbridgeces, volBridgeCES);
    _context.SendFloatToReceiver((uint) Parameter.Volbridgeec, volBridgeEC);
    _context.SendFloatToReceiver((uint) Parameter.Volbridgeecs, volBridgeECS);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc1, volMelodyC1);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc2, volMelodyC2);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc3, volMelodyC3);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc4, volMelodyC4);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc5, volMelodyC5);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc6, volMelodyC6);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc7, volMelodyC7);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodyc8, volMelodyC8);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye1, volMelodyE1);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye2, volMelodyE2);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye3, volMelodyE3);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye4, volMelodyE4);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye5, volMelodyE5);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye6, volMelodyE6);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye7, volMelodyE7);
    _context.SendFloatToReceiver((uint) Parameter.Volmelodye8, volMelodyE8);
  }
  
  private void Update() {
    // retreive sent messages
    if (_context.IsSendHookRegistered()) {
      Hv_UkuleleUnity_AudioLib.FloatMessage tempMessage;
      while ((tempMessage = _context.msgQueue.GetNextMessage()) != null) {
        FloatReceivedCallback(tempMessage);
      }
    }
  }

  private void OnAudioFilterRead(float[] buffer, int numChannels) {
    Assert.AreEqual(numChannels, _context.GetNumOutputChannels()); // invalid channel configuration
    _context.Process(buffer, buffer.Length / numChannels); // process dsp
  }
}

class Hv_UkuleleUnity_Context {

#if UNITY_IOS && !UNITY_EDITOR
  private const string _dllName = "__Internal";
#else
  private const string _dllName = "Hv_UkuleleUnity_AudioLib";
#endif

  // Thread-safe message queue
  public class SendMessageQueue {
    private readonly object _msgQueueSync = new object();
    private readonly Queue<Hv_UkuleleUnity_AudioLib.FloatMessage> _msgQueue = new Queue<Hv_UkuleleUnity_AudioLib.FloatMessage>();

    public Hv_UkuleleUnity_AudioLib.FloatMessage GetNextMessage() {
      lock (_msgQueueSync) {
        return (_msgQueue.Count != 0) ? _msgQueue.Dequeue() : null;
      }
    }

    public void AddMessage(string receiverName, float value) {
      Hv_UkuleleUnity_AudioLib.FloatMessage msg = new Hv_UkuleleUnity_AudioLib.FloatMessage(receiverName, value);
      lock (_msgQueueSync) {
        _msgQueue.Enqueue(msg);
      }
    }
  }

  public readonly SendMessageQueue msgQueue = new SendMessageQueue();
  private readonly GCHandle gch;
  private readonly IntPtr _context; // handle into unmanaged memory
  private SendHook _sendHook = null;

  [DllImport (_dllName)]
  private static extern IntPtr hv_UkuleleUnity_new_with_options(double sampleRate, int poolKb, int inQueueKb, int outQueueKb);

  [DllImport (_dllName)]
  private static extern int hv_processInlineInterleaved(IntPtr ctx,
      [In] float[] inBuffer, [Out] float[] outBuffer, int numSamples);

  [DllImport (_dllName)]
  private static extern void hv_delete(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern double hv_getSampleRate(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumInputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern int hv_getNumOutputChannels(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_setSendHook(IntPtr ctx, SendHook sendHook);

  [DllImport (_dllName)]
  private static extern void hv_setPrintHook(IntPtr ctx, PrintHook printHook);

  [DllImport (_dllName)]
  private static extern int hv_setUserData(IntPtr ctx, IntPtr userData);

  [DllImport (_dllName)]
  private static extern IntPtr hv_getUserData(IntPtr ctx);

  [DllImport (_dllName)]
  private static extern void hv_sendBangToReceiver(IntPtr ctx, uint receiverHash);

  [DllImport (_dllName)]
  private static extern void hv_sendFloatToReceiver(IntPtr ctx, uint receiverHash, float x);

  [DllImport (_dllName)]
  private static extern uint hv_msg_getTimestamp(IntPtr message);

  [DllImport (_dllName)]
  private static extern bool hv_msg_hasFormat(IntPtr message, string format);

  [DllImport (_dllName)]
  private static extern float hv_msg_getFloat(IntPtr message, int index);

  [DllImport (_dllName)]
  private static extern bool hv_table_setLength(IntPtr ctx, uint tableHash, uint newSampleLength);

  [DllImport (_dllName)]
  private static extern IntPtr hv_table_getBuffer(IntPtr ctx, uint tableHash);

  [DllImport (_dllName)]
  private static extern float hv_samplesToMilliseconds(IntPtr ctx, uint numSamples);

  [DllImport (_dllName)]
  private static extern uint hv_stringToHash(string s);

  private delegate void PrintHook(IntPtr context, string printName, string str, IntPtr message);

  private delegate void SendHook(IntPtr context, string sendName, uint sendHash, IntPtr message);

  public Hv_UkuleleUnity_Context(double sampleRate, int poolKb=10, int inQueueKb=53, int outQueueKb=2) {
    gch = GCHandle.Alloc(msgQueue);
    _context = hv_UkuleleUnity_new_with_options(sampleRate, poolKb, inQueueKb, outQueueKb);
    hv_setPrintHook(_context, new PrintHook(OnPrint));
    hv_setUserData(_context, GCHandle.ToIntPtr(gch));
  }

  ~Hv_UkuleleUnity_Context() {
    hv_delete(_context);
    GC.KeepAlive(_context);
    GC.KeepAlive(_sendHook);
    gch.Free();
  }

  public void RegisterSendHook() {
    // Note: send hook functionality only applies to messages containing a single float value
    if (_sendHook == null) {
      _sendHook = new SendHook(OnMessageSent);
      hv_setSendHook(_context, _sendHook);
    }
  }

  public bool IsSendHookRegistered() {
    return (_sendHook != null);
  }

  public double GetSampleRate() {
    return hv_getSampleRate(_context);
  }

  public int GetNumInputChannels() {
    return hv_getNumInputChannels(_context);
  }

  public int GetNumOutputChannels() {
    return hv_getNumOutputChannels(_context);
  }

  public void SendBangToReceiver(uint receiverHash) {
    hv_sendBangToReceiver(_context, receiverHash);
  }

  public void SendFloatToReceiver(uint receiverHash, float x) {
    hv_sendFloatToReceiver(_context, receiverHash, x);
  }

  public void FillTableWithFloatBuffer(string tableName, float[] buffer) {
    uint tableHash = hv_stringToHash(tableName);
    if (hv_table_getBuffer(_context, tableHash) != IntPtr.Zero) {
      hv_table_setLength(_context, tableHash, (uint) buffer.Length);
      Marshal.Copy(buffer, 0, hv_table_getBuffer(_context, tableHash), buffer.Length);
    } else {
      Debug.Log(string.Format("Table '{0}' doesn't exist in the patch context.", tableName));
    }
  }

  public uint StringToHash(string s) {
    return hv_stringToHash(s);
  }

  public int Process(float[] buffer, int numFrames) {
    return hv_processInlineInterleaved(_context, buffer, buffer, numFrames);
  }

  [MonoPInvokeCallback(typeof(PrintHook))]
  private static void OnPrint(IntPtr context, string printName, string str, IntPtr message) {
    float timeInSecs = hv_samplesToMilliseconds(context, hv_msg_getTimestamp(message)) / 1000.0f;
    Debug.Log(string.Format("{0} [{1:0.000}]: {2}", printName, timeInSecs, str));
  }

  [MonoPInvokeCallback(typeof(SendHook))]
  private static void OnMessageSent(IntPtr context, string sendName, uint sendHash, IntPtr message) {
    if (hv_msg_hasFormat(message, "f")) {
      SendMessageQueue msgQueue = (SendMessageQueue) GCHandle.FromIntPtr(hv_getUserData(context)).Target;
      msgQueue.AddMessage(sendName, hv_msg_getFloat(message, 0));
    }
  }
}
