using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;

public class ClearPersistentStorage : EditorWindow
{

    private List<FileInfo> files;

    [MenuItem("Tools/Clear Persistent Storage")]
    static void Init()
    {
        ClearPersistentStorage w = (ClearPersistentStorage)EditorWindow.GetWindow(typeof(ClearPersistentStorage));
        w.minSize = new Vector2(250, 400);
        w.Show();
    }

    private void OnGUI()
    {

        EditorGUILayout.LabelField("Path: " + Application.persistentDataPath);

        if(GUILayout.Button("Open folder"))
        {
            OpenFolder();
        }
        EditorGUILayout.Space(40);

        DirectoryInfo dir = new DirectoryInfo(Application.persistentDataPath);
        files = dir.GetFiles().ToList();

        if(files.Count() > 0)
        {
            foreach(var file in files)
            {
                if(GUILayout.Button(file.Name))
                {
                    file.Delete();
                }
            }

            EditorGUILayout.Space(40);

            if(GUILayout.Button("Clear all files"))
            {
                ClearAllFiles();
            }
        }
        else
        {
            EditorGUILayout.LabelField("No files in persistent storage");
        }

        EditorGUILayout.Space(40);
        if(GUILayout.Button("Add dummy data"))
        {
            AddDummyData();
        }

    }

    private void ClearAllFiles()
    {
        foreach(var file in files)
        {
            file.Delete();
        }
    }

    private void OpenFolder()
    {
        string path = Application.persistentDataPath;
        if(Application.platform == RuntimePlatform.WindowsEditor)
        {
            path.Replace(@"/", @"\");
        }
        EditorUtility.RevealInFinder(path);
    }

    private void AddDummyData()
    {
        // TODO: setup dummy data
    }
}
