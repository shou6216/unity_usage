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

## Unity（IDE）

### View

Unityは以下5つのViewで構成する

* Hierarchy
* Scene
* Game
* Project
* Inspector

#### Hierarchy

* シーンが持つオブジェクトの一覧を表示
  * Main Cameraのカメラ
  * Directional Lightのライト
  * Cubeなど

#### Scene

* シーンが持つオブジェクトを描画する（GUI)

#### Game

* カメラ視点からのSceneを表示
* 実際のゲームの画面

#### Inspector

* 選択したオブジェクトの詳細情報 
  * 位置、大きさなどをコンポーネント単位で表示 

#### Project

* シーン、スクリプトファイルなど実ファイルを表示

### スクリプトのエディタをVisual Studioにする

* Edit > Preferences > External Tools
* External Script EditorをVisual Studioにする

## Unityの基礎

### オブジェクトの作成

* [Hierarchy]の+ボタンから、Cubeなどオブジェクトを作成する

### C#スクリプトの作成

1. [Project]の+ボタンから「C# Script」を選択し、C#スクリプトを作成する
2. 作成したファイルをダブルクリック
3. Visual Studio起動
4. Visual Studioで実装
5. [Inspector]の「Add Component」->「Scripts」で作成したスクリプトを選択する

#### スクリプト

* デフォルトで`MonoBehaviour`を継承したクラスができる
* `Start`と`Update`という2つの関数が用意されている
* `Start`は、コメントにも書いてある通り初回起動時に呼ばれる
* `Update`は、フレームの更新ごとに毎回呼ばれる

### コンポーネント

* オブジェクトはコンポーネントという単位で様々な情報を持つ
  * 位置や大きさなども、 **Transform** コンポーネントのAttribute
  * 上記C#スクリプトも 1つのコンポーネントとして追加される 

### オブジェクトをイジる系

移動や大きさ、回転の変更方法は2つ

* [Inspector] の「Transform」コンポーネントのXYZ座標を直接イジる
* [Scene]の上方にある「Move Too」や「Rotate Tool」、「Scale Tool」に切り替えて直接D&Dなどで変更する

### オブジェクトの色を変える

1. [Project]の+から「Material」を作成する
2. 作成したマテリアルを選択し、[Inspector」から **Albedo** から任意の色を指定する
3. 変更したいオブジェクトを選択し、[Inspector]の「Mesh Renderer」 -> 「Materials」で作成したマテリアルを選択する

### オブジェクトに物理現象を適用する

1. [Inspector]から「Add Component」して「Physics] -> 「RigidBody」を追加
2. 「Use Gravity」にチェックを入れる
3. 再生ボタンを押すとどんどんオブジェクトが落下する

