 public static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int apple=0;
        int orange=0;
        foreach(int app in apples)    {
            if(app+a>=s && app+a<=t)
                apple++;
        }
        Console.WriteLine(apple);
        foreach(int org in oranges)    {
            if(org+a>=s && org+a<=t)
                orange++;
        }
        Console.WriteLine(orange);

    }