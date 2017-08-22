using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

/*
 * Loading Model, Textures, Etc, into Unity
 */

public class AssetsLoader : MonoBehaviour 
{
	private MeshFilter filter;
	private MeshRenderer renderer;
	private Material material;

    private List<Mesh> meshes;
    private string applicationPath;

	// Use this for initialization
	void Start () 
	{
		filter = GetComponent<MeshFilter>();
		renderer = GetComponent<MeshRenderer>();
		material = renderer.material;

        meshes = new List<Mesh>();
        applicationPath = Application.dataPath;
    }
	
	// Update is called once per frame
	void FixedUpdate () 
	{
        DirectoryInfo info = new DirectoryInfo(applicationPath);     // This should be in the root of the App (The dir where the EXE is found)
        FileInfo[] fileInfo = info.GetFiles();                              

        foreach(FileInfo file in fileInfo)
        {
            string extension = file.Extension;
            bool isModel = false;

            foreach(var ext in Enum.GetValues(typeof(ModelExtensions)))
            {
                isModel = String.Equals(extension, "." + ext.ToString(), StringComparison.CurrentCultureIgnoreCase);
                if (isModel) break;
            }

            if(isModel)
            {
                
            }
        }
    }
}

enum ModelExtensions
{
    OBJ,
    FBX,
    BLEND
}

enum ImageExtensions
{
    JPG,
    PNG
}

//TODO Look for TextureMapTypes
enum TextureMapTypes {
    ALBEDO,
    NORMAL,
    HEIGHTMAP,
    AO,
    METALLIC
}
