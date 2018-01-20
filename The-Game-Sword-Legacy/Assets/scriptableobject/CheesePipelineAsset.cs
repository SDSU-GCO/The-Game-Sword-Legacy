using UnityEngine;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
#endif



namespace CheeseRenderNamespace
{
    public class CheesePipelineAsset : RenderPipelineAsset
    {
        public Color color;
    #if UNITY_EDITOR
        [MenuItem("Assets/Create/Cheese Rendering/Render Pipeline Asset")]
        public static void MenuCreateCheeseRenderAsset()
        {
            Texture2D icon = EditorGUIUtility.FindTexture("SwordIcon.png");
            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, ScriptableObject.CreateInstance <CreateCheesePipelineAsset>(), "cheeseRender.asset", icon, null);
        }
    #endif
        protected override IRenderPipeline InternalCreatePipeline()
        {
            return new CheeseRenderPipeline(this);
        }
        public class CreateCheesePipelineAsset : EndNameEditAction
        {
            public override void Action(int instanceId, string pathName, string resourceFile)
            {
                CheesePipelineAsset instance = CreateInstance<CheesePipelineAsset>();
                instance.color = Color.black;
                AssetDatabase.CreateAsset(instance, pathName);
                ProjectWindowUtil.ShowCreatedAsset(instance);
            }
        }
    }



}
