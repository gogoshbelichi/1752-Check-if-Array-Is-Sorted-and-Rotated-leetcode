    //ищем rotation offset позицию где перестановка последовательностей произошла
    //это мы можем понять по изменению в последовательности, пример:
    //суть в том что подмассив non-descending(неубывающий == возрастающий),
    //но если меняется порядок(появилось число меньшее предыдущего) - значит пробуем перестановку,
    //если в перестановке все числа отсортированы по возврастанию значит true,
    //если нет возвращаем false
    //перефразирую: переставляем, если в результате получился отсортированный массив == все супер
    
    int[] nums1 = [0, 1, 2, 3, 4, 5];
    int[] nums2 = [2, 1, 3, 4, 5, 6];
    int[] nums3 = [3, 4, 5, 6, 1, 2];
    int[] nums4 = [6, 7, 8, 1, 2, 3];
    int[] nums5 = [2, 1];
    int[] nums6 = [2, 4, 1, 3];
    int[] nums7 = [2, 1, 2, 2, 2];
    int[] nums8 = [6, 7, 2, 7, 5];
    int[] nums9 = [7, 9, 1, 1, 1, 3];
    int[] nums10 = [10, 10, 1, 4, 5, 10];
    int[] nums11 =
    [
        4, 6, 9, 9, 10, 13, 13, 14, 14, 14, 15, 15, 15, 15, 16, 16, 18, 18, 19, 20, 20, 22, 22, 22, 24, 25, 25, 27, 27,
        28, 28, 31, 31, 33, 34, 36, 36, 36, 39, 40, 41, 41, 42, 42, 44, 47, 50, 52, 53, 53, 55, 55, 56, 63, 63, 70, 71,
        72, 72, 74, 76, 76, 77, 79, 80, 80, 80, 81, 84, 84, 85, 85, 88, 88, 89, 89, 89, 90, 91, 92, 93, 93, 94, 94, 94,
        96, 97, 97, 97, 97, 98, 99, 99, 100, 1, 1, 1, 2, 2, 4
    ];
    int[] nums12 =
    [
        38, 8, 53, 18, 57, 44, 56, 58, 57, 93, 56, 12, 89, 75, 37, 45, 57, 40, 67, 100, 6, 92, 100, 87, 47, 67, 47, 38,
        16, 21, 48, 29, 21, 61, 29, 84, 9, 23, 43, 22, 84, 50, 7, 21, 70, 31, 30, 22, 2, 76, 33, 25, 11, 51, 74, 95, 94,
        2, 50, 49, 55, 43, 93, 60, 44, 97, 52, 1, 63, 97, 66, 20, 84, 4, 85, 14, 85, 18, 15, 26, 51, 70, 52, 8, 95, 84,
        37, 4, 41, 97, 96, 17, 20, 98, 34, 70, 93, 83, 81, 62
    ];
    Console.WriteLine(Check(nums1));
    Console.WriteLine(Check(nums2));
    Console.WriteLine(Check(nums3));
    Console.WriteLine(Check(nums4));
    Console.WriteLine(Check(nums5));
    Console.WriteLine(Check(nums6));
    Console.WriteLine(Check(nums7));
    Console.WriteLine(Check(nums8));
    Console.WriteLine(Check(nums9));
    Console.WriteLine(Check(nums10));
    Console.WriteLine(Check(nums11));
    Console.WriteLine(Check(nums12));
    bool Check(int[] nums) {
        if (nums.Length == 1) return true;
        var offsetsList = OffsetsPosition(nums); 
        if (offsetsList.Count == 0) return true;
        if (offsetsList.Count > 1) return false;
        if (nums[0] < nums[nums.Length - 1]) return false;
        return true;
    }

    List<int> OffsetsPosition(int[] n) {
        var list = new List<int>();
        for(var i = 0; i < n.Length-1; i++) {
            int a = n[i];
            int b = n[i+1];
            if (b < a)
            {
                list.Add(i);
            }
        }
        return list;
    }