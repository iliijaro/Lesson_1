namespace HelloName_Lesson.Lesson10
{
    public class MyList<T>
    {
        private T[] myArray = Array.Empty<T>();

        public T this[int index]
        {
            get
            {
                return myArray[index];
            }
            set
            {
                myArray[index] = value;
            }
        }

        public void Add(T value)
        {
            var newArray = new T[myArray.Length + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }
            newArray[myArray.Length] = value;

            myArray = newArray;
        }

        public void Delete(T value)
        {
            var newArray = new T[myArray.Length - 1];

            for (int i = 0, j = 0; i < myArray.Length; i++)
            {
                if (value.Equals(myArray[i]))
                    continue;

                newArray[j] = myArray[i];
                j++;
            }
            myArray = newArray;
        }

        public int Count()
        {
            return myArray.Length;
        }

        public T GetElement(int i)
        {
            return myArray[i];
        }
    }
}