using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewerInterface : MonoBehaviour {
	private ModelInfo info;

	public ViewMode viewmode;
	public bool dAlbedo, dNormalMap, dHeightMap, dAmbientOcculusion, dMetallicMap;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}

public enum ViewMode 
{
	Shaded,
	Wireframe,
	ShadedWireframe
}
