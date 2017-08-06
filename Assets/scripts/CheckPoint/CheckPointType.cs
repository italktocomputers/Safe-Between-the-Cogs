public class CheckPointType {
    public float x;
    public float y;
    public float time;

    public CheckPointType(float x, float y, float time) {
        this.x = x;
        this.y = y;
        this.time = time;
    }

    public override string ToString() {
        return x.ToString() + "," + y.ToString() + "," + time.ToString();
    }
}
