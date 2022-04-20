namespace Algoritms_and_DataStructure.Lesson2;

public class BinarySearch<T> where T: List<int>
{
    private List<int> _list;
    
    public BinarySearch(T data)
    {
        _list = data;
    }

    public int BinarySearchFunction(int searchValue)
    {
        _list.Sort();
        int left = 0;
        int right = _list[_list.Count];
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (_list[mid] == searchValue)
            {
                return mid;
            }
            else if(searchValue < _list[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;

    }
}