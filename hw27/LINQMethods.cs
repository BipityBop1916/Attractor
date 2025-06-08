namespace hw27;

public static class LINQMethods
{
    public static List<int> Method1(List<int> list) => list.Where(x => x < 0).Where(x => x % 2 == 0).ToList();
    
    public static int Method2(List<int> list) => list.Where(x => x > 0).DefaultIfEmpty(0).Min();
    
    public static List<string> Method3(List<int> list) => list.Where(x => x % 2 == 1).OrderBy(x => x).Select(x => x.ToString()).OrderBy(x => x).ToList();
    
    public static List<int> Method4(List<int> list, int digit) => list.Where(x => x > 0).Where(x => int.Parse(x.ToString().ToList()[^1].ToString()) == digit).ToList();

    public static List<string> Method5(List<string> list, int index) =>
        list.Slice(0, index).Where(x => x.ToString().Length % 2 == 1).Where(x => char.IsUpper(x.ToString().ToList()[0])).Reverse().ToList();
    
    public static List<int> Method6(List<int> list) => list.Select((x, i) => x*i).Where(x => x.ToString().Length == 2).Reverse().Where(x => x > 0).OrderBy(x => x).Reverse().Concat(list.Select((x, i) => x*i).Where(x => x.ToString().Length == 3).Reverse().Where(x => x < 0).OrderBy(x => x).Reverse()).ToList();

    public static List<string> Method7(List<string> list, int length) => list.Select(x => x.Split(".")).SelectMany(x => x).Where(x => x.Length >= length).OrderBy(x => x.Length).ThenBy(y => y).ToList();
}