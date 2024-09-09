
int[] arr = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 };
int[] arr1 = xoaPhanTuKhoiMang(arr, 7);
// ham xoa phan tu trong mang
static int[] xoaPhanTuKhoiMang(int[] arr, int x)
{
    int index_del = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            index_del = i;
            break;
        }
    }
    for (int i = index_del; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    return arr;
}
Console.WriteLine(string.Join(",",arr1));