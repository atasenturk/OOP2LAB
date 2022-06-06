namespace OopLab
{
    public class QItem
    {
        public int row;
        public int col;
        public int dist;
        public QItem(int x, int y, int w)
        {
            this.row = x;
            this.col = y;
            this.dist = w;
        }
    }
}
