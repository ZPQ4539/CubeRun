using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetBundleEditor : Editor
{
    //打包路径
    public static readonly string Path = Application.dataPath + "/Bundle";
    //输出路径
    public static readonly string PrintPath = "";

    private Dictionary<string, byte[]> Files = new Dictionary<string, byte[]>();

    [MenuItem("Tools/AssetBundle/Build")]
    public static void Init()
    {
        Debug.Log(Path + "打包路径");
        ReadFile();
    }

    /// <summary>
    /// 读取文件
    /// </summary>
    private static void ReadFile()
    {
        string[] listTemp = Directory.GetFiles(Path,"*.*",SearchOption.AllDirectories);

        for (int i = 0; i < listTemp.Length; i++)
        {
            if (listTemp[i].EndsWith(".meta"))
            { 
                continue;
            }
            Debug.Log(listTemp[i]);
        }
    }
}
