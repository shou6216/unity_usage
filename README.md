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
   * C#スクリプトファイルをD&Dで[Hierarchy]のオブジェクトに追加してもよい

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

* [Inspector]から「Add Component」して「Physics] -> 「RigidBody」を追加

#### 重力

* 「Use Gravity」にチェックを入れる
* 再生ボタンを押すとどんどんオブジェクトが落下する

#### 力を加える

```c#
Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
// 第一引数からX,Y,Z軸を表す。下記はX軸方向にのみ力1000を加える
rigidbody.AddForce(1000, 0, 0);
```

#### 物体の衝突を検出する

* 検出オブジェクトにRigidbodyコンポーネントを追加する必要がある

```c#
void OnCollisionEnter(UnityEngine.Collision collision)
{
    // 衝突したオブジェクトの情報を表示
    Debug.Log(collision.gameObject.name);
}
```

#### 物体のすれ違い(すり抜け）を検出する

* 検出オブジェクトのXXXX Collider(Sphere Collider)コンポーネントの「Is Trigger」にチェックを入れる

```c#
void OnTriggerEnter(Collider other)
{
    // すれ違ったオブジェクトの情報を表示
    Debug.Log($"{other.gameObject.name}とすれ違った");
}
```

### キー入力

* C#スクリプトのUpdate関数内で実装する

#### 水平方向

```c#
float horizontal = Input.GetAxis("Horizontal");
```
* 戻り値は-1.0 < horizontal < 1.0の範囲
* 左矢印キーを押すと-1.0に近づく
* 右矢印キーを押すと1.0に近づく
* 何も押してない時は0

#### 垂直方向

```c#
float vertical = Input.GetAxis("Vertical");
```
* 戻り値は-1.0 < vertical < 1.0の範囲
* 上矢印キーを押すと-1.0に近づく
* 下矢印キーを押すと1.0に近づく
* 何も押してない時は0

### オブジェクト情報の取得

#### スクリプトを追加したオブジェクト情報の取得

* `gameObject`という変数名固定のインスタンス変数が予め用意されている
* `gameObject.name`でスクリプトを追加したオブジェクトの名前を取得できる
* コンポーネントは`gameObject.GetComponent<Camera>()`

#### 任意のオブジェクト情報を取得

1. C#スクリプト内で、参照したいオブジェクトを`public`なインスタンス変数に定義する
```c#
public GameObject cube; // publicなGameObject型の変数を定義
```
2. この状態でUnityに戻って、[Inspector]のスクリプトのところを見ると、cubeの変数に対してオブジェクトを指定できる
3. 指定する
4. C#スクリプトに戻って、あとはやりたいことやる

#### 任意のコンポーネント情報を取得

* 基本オブジェクトと同じ、`public`なインスタンス変数を定義して、Unity側で設定する

### オブジェクトの削除

```c#
Destroy(gameObject);
```

### UI

* TextやButtonなどUIパーツはCanvasオブジェクトという領域を用意してそこに追加する
* [Hierarchy]でCanvasオブジェクトを作って、その中にTextなどUIオブジェクトを追加する

#### Text

* Textコンポーネントで文字変更
* Rect Transformでサイズなど変更

##### テキストをスクリプトで変更

* UI.Textコンポーネントのtextを変更する

```c#
gameObject.GetComponent<UIEngine.UI.Text>().text = "hoge";
```

### Tag

* オブジェクトにタグをつけてグル-ピングできる
* C#スクリプトで取得できる

```c#

// 単一
GameObject gameObject = GameObject.FindWithTag("タグ名");

// 複数
GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("タグ名");
```

### Scene

#### Sceneの読み込み

* シーンIDは、File > Build Settings... > Scenes in Buildに出てくるSceneごとのID

```c#
void Start()
{
   UnityEngine.SceneManegement.SceneManager.LoadScene(シーンID);
}
```
