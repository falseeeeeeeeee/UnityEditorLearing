using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class TestSceneMenu : MonoBehaviour
    {
        // 初始化特性
        [InitializeOnLoadMethod]
        static void InitialzeOnLoad()
        {
            // 监听这个委托
            UnityEditor.SceneView.duringSceneGui += (sceneView) =>  
            {
                // 不等于空 && 0是鼠标左键，1是鼠标右键 && 鼠标抬起来
                if (Event.current != null && Event.current.button == 1 && Event.current.type == EventType.MouseUp)  
                {
                    // Debug.Log("鼠标右键抬起");

                    // 位置
                    Rect position = new Rect(Event.current.mousePosition.x, Event.current.mousePosition.y-100, 100, 100);
                    // 内容 随便定义一些数组
                    GUIContent[] contents = new GUIContent[] {new GUIContent("Test1"), new GUIContent("Test2")};
                    
                    EditorUtility.DisplayCustomMenu(position, contents, -1, (data, opt, select) =>
                    {
                        Debug.LogFormat("data:{0},opt:{1},select:{2},value{3}", data, opt, select, opt[select]);
                    }, null);
                    
                    // 让鼠标还是原来的样式
                    Event.current.Use();
                }
            }; 
        }

    }
}
