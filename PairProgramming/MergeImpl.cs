namespace PairProgramming
{
    public class MergeImpl : IMerge
    {
        public int[] Merge(int[] a, int[] b)
         
            {
                int length = a.Length + b.Length;
                int[] merge = new int[length];
                int i;
                for (i = 0; i < a.Length; i++)
                {
                    merge[i] = a[i];
                }

                for (int j = 0; j < b.Length; j++)
                {
                    merge[j + i] = b[j];
                }

                merge = SortMerge(merge);
                return merge;
            }

            public int[] SortMerge(int[] merge)
            {
                int temp;
                for (int i = 0; i < merge.Length; i++)
                {
                    for (int j = 0; j < merge.Length-1; j++)
                    {
                        if (merge[j] > merge[j + 1])
                        {
                            temp = merge[j + 1];
                            merge[j + 1] = merge[j];
                            merge[j] = temp;
                        }
                    
                    }
                }

                return merge;
            }
        }
    }