namespace CPro_1.Helper
{
    public static class LINQRequest
    {
        public static T Panultimate<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException();

            var list = source as IList<T> != null ? (IList<T>)source : source.ToList();

            return list[list.Count() - 2];
        }
    }
}
