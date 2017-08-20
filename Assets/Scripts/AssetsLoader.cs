using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Loading Model, Textures, Etc, into Unity
 */

public class AssetsLoader : MonoBehaviour 
{
	private MeshFilter filter;
	private MeshRenderer renderer;
	private Material material;

	// Use this for initialization
	void Start () 
	{
		filter = GetComponent<MeshFilter>();
		renderer = GetComponent<MeshRenderer>();
		material = renderer.material;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
