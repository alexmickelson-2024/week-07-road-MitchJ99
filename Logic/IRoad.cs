namespace Logic
{
    public interface IRoad
    {
        int RowCount { get; }
        int ColCount { get; }
        IVehicle GetVehicle(int row, int col);
        void SetVehicle(int row, int column, IVehicle vehicle);
    }
}

namespace Logic
{
    public class Road : IRoad
    {
        private IVehicle[] vehicles;

        public int RowCount { get; }
        public int ColCount { get; }

        public Road(int rows, int columns)
        {
            RowCount = rows;
            ColCount = columns;
            vehicles = new IVehicle[rows, columns];
        }

        public IVehicle GetVehicle(int row, int col)
        {
            return vehicles[row, col];
        }

        public void SetVehicle(int row, int col, IVehicle vehicle)
        {
            vehicles[row, col] = vehicle;
        }
    }
}

