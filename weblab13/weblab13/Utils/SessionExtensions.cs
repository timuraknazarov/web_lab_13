using System.Text.Json;

namespace lab2_3.Utils
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return session.GetString(key) switch
            {
                { } value => JsonSerializer.Deserialize<T>(value),
                null => default
            };
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }
    }
}
