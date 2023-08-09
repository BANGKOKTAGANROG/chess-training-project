using Game;

namespace Program {
    public class Game {
        public static void Main() {
            Board board = new();
            board.SetupDefaultPosition();
            BoardRenderer renderer = new(board);
            renderer.Render();
        }
    }
}