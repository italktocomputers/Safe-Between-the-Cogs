using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceManager : MonoBehaviour {
    protected ISurface currentSurface;
    protected Dictionary<string, ISurface> surfaces = new Dictionary<string, ISurface>();

    private void Start() {
        SurfaceRock surfaceRock = new SurfaceRock(gameObject);
        SurfaceSand surfaceSand = new SurfaceSand(gameObject);
        SurfaceSticky surfaceSticky = new SurfaceSticky(gameObject);
        SurfaceWater surfaceWater = new SurfaceWater(gameObject);
        SurfaceAir surfaceAir = new SurfaceAir(gameObject);

        surfaces["Ground"] = surfaceRock;
        surfaces["Wall"] = surfaceRock;
        surfaces["Platform"] = surfaceRock;
        surfaces["Sand"] = surfaceSand;
        surfaces["Water"] = surfaceWater;
        surfaces["Air"] = surfaceAir;
        surfaces["StickyBlock"] = surfaceSticky;

        currentSurface = surfaceRock;
    }

    public void sendAction(InputAction action) {
        if (currentSurface != null) {
            switch (action) {
                case InputAction.Jump:
                    currentSurface.Jump();
                    break;
                case InputAction.WalkLeft:
                    currentSurface.MoveLeft();
                    break;
                case InputAction.WalkRight:
                    currentSurface.MoveRight();
                    break;
                case InputAction.ClimbUp:
                    currentSurface.MoveUp();
                    break;
                case InputAction.ClimbDown:
                    currentSurface.MoveDown();
                    break;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (surfaces.ContainsKey(other.gameObject.tag)) {
            surfaces[other.gameObject.tag].OnEnter(other);
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (surfaces.ContainsKey(other.gameObject.tag)) {
            surfaces[other.gameObject.tag].OnExit(other);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (surfaces.ContainsKey(other.gameObject.tag)) {
            surfaces[other.gameObject.tag].OnEnterTrigger(other);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (surfaces.ContainsKey(other.gameObject.tag)) {
            surfaces[other.gameObject.tag].OnExitTrigger(other);
        }
    }

    private void OnCollisionStay2D(Collision2D collisionInfo) {
        if (surfaces.ContainsKey(collisionInfo.gameObject.tag)) {
            currentSurface = surfaces[collisionInfo.gameObject.tag];
        }
    }

    private void OnTriggerStay2D(Collider2D collisionInfo) {
        if (surfaces.ContainsKey(collisionInfo.gameObject.tag)) {
            currentSurface = surfaces[collisionInfo.gameObject.tag];
        }
    }
}