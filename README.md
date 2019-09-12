# MSTestLog  
用來在 MSTest 測試專案中，寫入 Log 的工具  
寫入 Log 跟寫 Console.WriteLine(xxxxx) 一樣簡單  
能夠一次寫入多行 Log  
寫入的 Log 統一放在 Test Explorer 的 Test Case 中的 Output 視窗頁裡

使用上，記得在測試專案上呼叫 MSTestLog.Initialize() 初始化 MSTestLog 這個類別庫  
``` c#
using MSTestTool;

[TestClass]
public class UnitTest3dData
{
    [TestInitialize]
    public virtual void Initialize()
    {
        MSTestLog.Initialize();
    }
}
```
使用上可以在任何地方寫 log  
``` c#
MSTestLog.WriteLine("++產生錯誤訊息 1++");

MSTestLog.WriteLine("++產生錯誤訊息 2++");
```
![](https://i.imgur.com/IlLQ30e.png)
點擊「Output」  
![](https://i.imgur.com/6ZUwsHU.png)
就可以看到多個 log  

與 Assert 混用  
``` c#
Assert.AreEqual(true, false, MSTestLog.WriteLine("++產生錯誤訊息++"));
```
點擊「Output」
![](https://i.imgur.com/NTTPIA8.png)
就可以看到 log  
![](https://i.imgur.com/2cE8qf8.png)
