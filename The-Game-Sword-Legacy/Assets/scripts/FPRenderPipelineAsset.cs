using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
#endif



namespace FPRenderNamespace
{
    public class FPRenderPipelineAsset : RenderPipelineAsset
    {
		//create a variable that holds a color.  This can be set via the editor.
        public Color color;

        public static List<FPRenderComponent> ListOfRenderComponent = new List<FPRenderComponent>();

        //if we are working in the unity editor
#if UNITY_EDITOR
        [MenuItem("Assets/Create/Food Processor Rendering/Render Pipeline Asset")]//create a menue item
	        public static void MenuCreateFPRenderAsset()//that runs this function
	        {

				//Create a link to a 2d sprite Icon in the "Gizmos" folder.
	            Texture2D icon = EditorGUIUtility.FindTexture("SwordIcon.png");

				//Create a new scriptable object rendering pipeline witht the icon we just made in the assets folder.
	            ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, ScriptableObject.CreateInstance <CreateFPPipelineAsset>(), "cheeseRender.asset", icon, null);
	        }
	    #endif

		//This returns an instance of our pipeline... I don't actually know why we need this.
        protected override IRenderPipeline InternalCreatePipeline()
        {
			//returns a copy of itself(pass by value)
			return new FPRenderPipeline(this);
        }

		//create a new pipeline asset that inherits from EndNameEditAction.
		//I have no clue what EndNameEditAction actually is or what it does.
        public class CreateFPPipelineAsset : EndNameEditAction
        {
			//I don't know what calls this.  I also don't know what it does.
            public override void Action(int instanceId, string pathName, string resourceFile)
            {
                //we store an instance of our cheese pipeline asset into instance
                FPRenderPipelineAsset instance = CreateInstance<FPRenderPipelineAsset>();

				//we default the color to black
                instance.color = Color.black;

				//I don't know what this paths to.
                AssetDatabase.CreateAsset(instance, pathName);

				//this MIGHT be updating the project folder??????
                ProjectWindowUtil.ShowCreatedAsset(instance);
            }
        }
    }



}
