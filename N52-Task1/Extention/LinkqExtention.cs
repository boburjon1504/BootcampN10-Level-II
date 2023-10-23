namespace N52_Task1.Extention;

public static class LinkqExtention
{
    public static IEnumerable<(TSourse, TSourse)> ZipIntersectBy<TSourse, TKey>(this IEnumerable<TSourse> itemA,
        IEnumerable<TSourse> itemB,
        Func<TSourse, TKey> keySelector
        )
    {
        foreach ( var item in itemA )
        {
            var a = keySelector(item );
            var b = itemB.FirstOrDefault( ite=>!keySelector(ite).Equals(a));
            yield return (item, b);
        }
    }
}
