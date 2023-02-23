using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class TestMenu : MonoBehaviour
    {
        [MenuItem("ChaoTest/MenuItem/MenuItem1",false,0)]
        static void MenuItem1()
        {
            Debug.Log("Hello Editor MenuItem1");
        }
    
        [MenuItem("ChaoTest/MenuItem/MenuItem2",false,11)]
        static void MenuItem2()
        {
            Debug.Log("Hello Editor MenuItem2");
        }
    
        [MenuItem("ChaoTest/MenuItem/MenuItem1",true)]   //是否是验证函数，要与MenuItem1名称相同
        static bool MenuItem1Validate()
        {
            return true;   //ture可以点击，false不可以点击
        }
    }
}
