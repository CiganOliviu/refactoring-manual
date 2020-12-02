namespace EndPoint
{
    public class OneDimensionalArray
    {
        private int _length;
        private int[] _oneDimensionalArray = { };

        public void SetLength(int length)
        {
            this._length = length;
        }

        public int GetLength()
        {
            return this._length;
        }

        public void SetOneDimensionalArray(int[] newArray)
        {
            this._oneDimensionalArray = newArray;
        }
        public int[] GetOneDimensionalArray()
        {
            return this._oneDimensionalArray;
        }
    }
}