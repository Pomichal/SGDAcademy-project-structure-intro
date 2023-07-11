using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public static class JsonParser
{
    public static void SerializeAndSave(object o, string name = "data", string path = "")
    {
        string json = JsonConvert.SerializeObject(o);
        Debug.Log(json);

        if(path=="")
        {
            path = Application.persistentDataPath + "/";
        }

        System.IO.File.WriteAllText(path + name + ".json", json);
    }

    public static T Deserialize<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);

    }
}
