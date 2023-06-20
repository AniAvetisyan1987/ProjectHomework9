namespace ProjectHomework9
{
    internal class NewArrayClass
    {
        public int[] arr;
        public NewArrayClass(int[] arr)
        {
            this.arr = arr;
        }

        private int[] getNewArray()
        {
            int[] newArray = new int[] { };
            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                        if (count > 1)
                        {
                            
                            if (!Array.Exists(newArray, element => element == arr[j]))
                            {
                                newArray = newArray.Append(arr[j]).ToArray();
                            }
                        }
                    }
                } 
            }
            return newArray;
        }

        public void getSum()
        {
            Console.WriteLine(getNewArray().Sum());
        }
    }
}
