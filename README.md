# Unity学習用プロジェクト

## 開発環境構築

### Unity Hub

* [ダウンロード](https://unity3d.com/jp/get-unity/download)する
* インストールはウィザード通り
* 起動
* 右上のユーザーアイコンからサインイン
  * 事前にUnity IDを用意しておく
  * なければ作成する
* 歯車アイコンからライセンス認証

### Unity

* Unity Hubの「インストール」からUnityをインストールする
* 一緒にインストールするモジュール
  * Visual Studio
  * OSに合わせたライブラリ

## UnityのIDE

Unityは以下5つのViewで構成する

* Hierarchy
* Scene
* Game
* Project
* Inspector

### Hierarchy

* シーンが持つオブジェクトの一覧を表示
  * Main Cameraのカメラ
  * Directional Lightのライト
  * Cubeなど

### Scene

* シーンが持つオブジェクトを描画する（GUI)

### Game

* カメラ視点からのSceneを表示
* 実際のゲームの画面

### Inspector

* 選択したオブジェクトの詳細情報 
  * 位置、大きさなどをコンポーネント単位で表示 

### Project

* シーン、スクリプトファイルなど実ファイルを表示

## Unityの基礎

### オブジェクトの作成

* Hierarchyの+ボタン
* オブジェクトにコンポ―ネントという粒度で機能を追加する

### UnityにVisual Studioを設定

* Edit > Preferences > External Tools
* External Script EditorをVisual Studioにする

### C#スクリプト作成

1. Project Viewの+ボタン
2. C#スクリプト追加
3. 追加したファイルを選択
4. Visual Studio起動
5. オブジェクトに「Add Component」する
6. Scriptsで追加したC#スクリプトを追加
