using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Essensoft.AspNetCore.Payment.UnionPay.Utility
{
    public static class UnionPayUtils
    {
        internal static object TryTo<T>(this object Object)
        {
            return Object.TryTo(typeof(T));
        }

        /// <summary>
        /// 尝试将对象实例转换成目标类型
        /// </summary>
        /// <typeparam name="T">对象实例类型</typeparam>
        /// <typeparam name="R">目标类型</typeparam>
        /// <param name="Object">对象实例</param>
        /// <param name="DefaultValue">默认值</param>
        /// <returns>转换后类型</returns>
        internal static object TryTo(this object Object, Type destinationType)
        {
            try
            {
                if (Object == null || Convert.IsDBNull(Object))
                {
                    return GetDefault(destinationType);
                }

                if ((Object as string) != null)
                {
                    var ObjectValue = Object as string;
                    if (destinationType.IsEnum)
                    {
                        return System.Enum.Parse(destinationType, ObjectValue, true);
                    }

                    if (string.IsNullOrEmpty(ObjectValue))
                    {
                        return GetDefault(destinationType);
                    }
                }
                if ((Object as IConvertible) != null)
                {
                    var destination =
                       destinationType.IsGenericType && destinationType.GetGenericTypeDefinition() == typeof(Nullable<>) ?
                           Nullable.GetUnderlyingType(destinationType) : destinationType;
                    return Convert.ChangeType(Object, destination);
                }
                if (destinationType.IsAssignableFrom(Object.GetType()))
                {
                    return Object;
                }

                var Converter = TypeDescriptor.GetConverter(Object.GetType());
                if (Converter.CanConvertTo(destinationType))
                {
                    return Converter.ConvertTo(Object, destinationType);
                }
            }
            catch { }
            return GetDefault(destinationType);
        }

        private static object GetDefault(Type type)
        {
            var defaultExpr = Expression.Default(type);
            return Expression.Lambda<Func<object>>(defaultExpr).Compile()();
        }

    }
}
