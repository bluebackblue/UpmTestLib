

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief デバッグツール。
*/


/** BlueBack.TestLib
*/
namespace BlueBack.TestLib
{
	/** DebugTool
	*/
	public class DebugTool
	{
		/** Assert
		*/
		#if(DEF_BLUEBACK_TESTLIB_ASSERT)
		public static void Assert(bool a_flag,System.Exception a_exception = null)
		{
			if(a_flag != true){
				Config.ERRORPROC(a_exception);
			}
		}
		#endif

		/** ErrorProc
		*/
		#if(DEF_BLUEBACK_TESTLIB_ASSERT)
		public static void ErrorProc(System.Exception a_exception)
		{
			if(a_exception != null){
				UnityEngine.Debug.LogError(a_exception.ToString());
			}
			UnityEngine.Debug.Assert(false);
		}
		#endif

		/** EditorLog
		*/
		#if(UNITY_EDITOR)
		public static void EditorLog(string a_text)
		{
			UnityEngine.Debug.Log(a_text);
		}
		#endif

		/** EditorLogError
		*/
		#if(UNITY_EDITOR)
		public static void EditorLogError(string a_text)
		{
			UnityEngine.Debug.LogError(a_text);
		}
		#endif
	}
}
