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
  * インストール
* モジュール
  * Visual Studio
  * 実行環境に合わせたライブラリ

## IDE

### View

#### Hierarchy

* すべてのオブジェクトを表示
* デフォルトは`SampleScene`に対して以下のみ
  * Main Cameraのカメラ
  * Directional Lightのライト

#### Scene

* オブジェクトの表示

#### Game

* Main Cameraが映している画面
* 実際のゲームの画面

#### Inspector

* 選択したオブジェクトの詳細情報

#### Project

* Assetsの表示

### オブジェクトの作成

* Hierarchyの+ボタン
* オブジェクトにコンポ―ネントという粒度で機能を追加する

### UnityにVisual Studioを設定

* Edit > Preferences > External Tools
* External Script EditorをVisual Studioにする

### C#スクリプト作成

* Project Viewの+ボタン
* C#スクリプト追加
* 追加したファイルを選択
* Visual Studio起動
