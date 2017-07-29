using UnityEngine;

public interface ISurface {
    void Jump();
    void MoveUp();
    void MoveDown();
    void MoveLeft();
    void MoveRight();
    void OnEnter(Collision2D collision);
    void OnExit(Collision2D collision);
    void OnEnterTrigger(Collider2D other);
    void OnExitTrigger(Collider2D other);
}
