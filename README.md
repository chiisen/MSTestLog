# MSTestLog 🚀

這是一個專為 **MSTest** 測試專案設計的 Log 工具，能幫助開發者輕鬆地在測試過程中記錄訊息。 📝

## 🌟 特色
- 🚀 已升級至 **.NET 10** 與 **C# 13**。
- 統一將 Log 輸出至 **Test Explorer** 中 Test Case 的 **Output** 視窗。
- 支援在測試程式碼的任何地方進行記錄。
- 完美整合 MSTest 的 `Assert` 功能。
- 支援 **Nullable Reference Types** 與 **Implicit Usings**。

---

## 🛠️ 初始化 (Initialization)

在使用前，請務必在測試類別中呼叫 `MSTestLog.Initialize()` 來初始化類別庫。建議放在 `[TestInitialize]` 方法中： ⚙️

```csharp
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

---

## 📖 使用方式 (Usage)

初始化後，您可以在任何地方隨時記錄 Log： ✨

```csharp
MSTestLog.WriteLine("++產生錯誤訊息 1++");
MSTestLog.WriteLine("++產生錯誤訊息 2++");
```

![](https://i.imgur.com/IlLQ30e.png)

### 🔍 查看輸出
在 **Test Explorer** 中點擊該測試案例的 **「Output」** 連結：

![](https://i.imgur.com/6ZUwsHU.png)

即可看到多個 Log 記錄內容。 📋

---

## 💡 與 Assert 混用

您可以將 Log 記錄直接與 `Assert` 結合使用，讓測試失敗時的上下文資訊更清晰：

```csharp
Assert.AreEqual(true, false, MSTestLog.WriteLine("++產生錯誤訊息++"));
```

點擊 **「Output」**：

![](https://i.imgur.com/NTTPIA8.png)

就能在輸出視窗中看到 Log 資訊： 🔍

![](https://i.imgur.com/2cE8qf8.png)

