public class CheckpointType {
    public float x;
    public float y;
    public float time;

    public CheckpointType(float x, float y, float time) {
        this.x = x;
        this.y = y;
        this.time = time;
    }

    public override string ToString() {
        return x.ToString() + "," + y.ToString() + "," + time.ToString();
    }
}
