using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    //プレイヤーの入力(WASD、矢印キー)が入力されたらStageを回転させる
    private InputAction _playerInput;

    //　回転させたい対象のオブジェクト
    [SerializeField]
    private GameObject _stage;

    // 1.private ＝ アクセス修飾子。「このクラスの中からしか触れない」という意味。
    // 2.InputAction　＝　型(クラス名)。Unityの新しい入力システムで使う「入力アクション」を表す型。
    // 3._playerInput　＝　変数名。「プレイヤー入力を扱う変数」という名前。
    // 4.;　＝　行の終わりを示す記号。
    // 5.private InputAction _playerInput;　＝　「クラス内で使う、InputAction型の＿playerlnputという変数を宣言している」という意味になる。



    
    // void Start() = 関数(メソッド)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Inputsystem.actions.FindAction("Move")
        // ↑InputSysteｍのアクションマップから"Move"という名前のアクションを探して取得
        _playerInput = InputSystem.actions.FindAction("Move");
    }

    //　１フレーム毎にこの関数が呼ばれる
    // Update is called once per frame
    void Update()
    {
        // _playerInputの値によってステージを回転させる
        Debug.Log(_playerInput.ReadValue<Vector2>());
        //Stageを回転させる処理
        // 水平( horizontal)入力の取得
        float horizontalInput = _playerInput.ReadValue<Vector2>().x;
        // 垂直(vertical)入力の取得
        float verticalInput = _playerInput.ReadValue<Vector2>().y;

        //　オブジェクトを回転させる
        _stage.transform.Rotate(horizontalInput * 0.5f, 0f, verticalInput * 0.5f);

    }
}
