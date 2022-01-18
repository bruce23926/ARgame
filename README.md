# ARgame
Unity版本: 2019.4.32f1
ARCore XR Plugin 2.1.18
XR Plugin Management 4.0.1

1/8/2021
分數程式
1. 在 Unity UI 創建 ”Canvas”
2. 添加按鈕作為觸發器 [UI] > [Button]
3. 添加“text”，將其命名為“Score Amount”，這將顯示當前分數 [UI] > [Text]
4. 在文本“Score Amount”中添加腳本，命名為 Score.cs
5. 在按鈕檢查器上，轉到“單擊時”並選擇“添加分數”的功能 [Score] > [Add Score()]

1/8/2021
開始遊戲界面
1. 在 Unity UI中創建新場景並添加 Canvas [UI] > [Canvas]
2. 將界面設計插入畫布
3. 添加開始按鈕 [UI] > [Button]
4. 要更改按鈕，找到按鈕的“Inspector”並蒐索“Source Image”，您可以在那裡輸入您的按鈕設計
5. 在畫布上，創建新script叫“Start_Menu.cs”
6. 在開始按鈕的”Inspector”上，找到 [On Click] 並將腳本插入到 Canvas 中
7. 將功能從 [No Function] 更改為 [Start Menu] > [Start Game()]
8. 現在要將其與遊戲場景合併，請轉到 [File] > [Build Settings]
9. 在 Build Settings 中，拖動兩個場景（開始菜單場景和遊戲場景），開始必須在遊戲場景上，因為順序是開始 > 遊戲, 然後按[Build]

組員名單:
互動三 
108840003 白紹廷
108AC1028 賴品尤
108AC2029 龐琼美 108AC2029
