namespace Pieces {
    public class Coordinates {
        public readonly Files file;
        public readonly int rank;

        public Coordinates(Files file, int rank) {
            this.file = file;
            this.rank = rank;
        }

        public override bool Equals(Object? obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            if (this == obj) {
                return true;
            }

            Coordinates that = (Coordinates)obj;

            if (file != that.file) {
                return false;
            }
            return rank.Equals(that.rank);
        }

        public override int GetHashCode() {
            return HashCode.Combine(file, rank);
        }
    }
}