using static System.Console;
using System.Collections.Generic;
using System.Diagnostics;
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
List<int> list = new List<int>(10);
Random rnd = new Random();
for (int i = 0; i < list.Capacity; i++)
{

    list.Add(rnd.Next(1, 100));
    WriteLine(list[i]);
}

for (int i = 1; i < list.Count; i++)
{
    if (list[i] % list[0] == 0)
    {
        list.RemoveAt(i);
        i--;
    }
}
foreach (int i in list)
{
    Write(" " + i);
}
WriteLine();
for (int i = 0; i < list.Count; i++)
{
    list.RemoveAll(x => x % 2 == 0);
    list.Insert(i, 0);

}
foreach (int i in list)
{
    Write(" " + i);

}

stopWatch.Stop();
WriteLine();
WriteLine($"Времени затрачено: {stopWatch.Elapsed} ");
WriteLine("--------------------------------------------------------");
stopWatch.Start();
LinkedList<int> list2 = new LinkedList<int>
{

};
for (int i = 0; i < 10; i++)
{
    list2.AddFirst(rnd.Next(1, 100));
    WriteLine(list2.First());
}

for (int i = 1; i < list2.Count; i++)
{
    if (list2.Last() % list2.First() == 0)
    {
        list2.Remove(i);
        i--;
    }
}
foreach (int i in list2)
{
    Write(" " + i);
}
WriteLine();
for (int i = 0; i < list2.Count; i++)
{
    //int j = i % 2;
    if (list2.Contains(i % 2)) //спросить
    {
        list2.Remove(i);
        //list2.AddBefore(j,0);
    }


}
foreach (int i in list2)
{
    Write(" " + i);

}
stopWatch.Stop();
WriteLine();
WriteLine($"Времени затрачено: {stopWatch.Elapsed} ");

//доделать ...