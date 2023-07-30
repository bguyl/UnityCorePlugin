namespace Guyl.Core.Editor
{
    using UnityEditor;
    
    public class Utils
    {
        [MenuItem("Core/Utils/Reload Assemblies")]
        private static void ReloadAssemblies()
        {
            EditorUtility.RequestScriptReload();
        }
    }
}