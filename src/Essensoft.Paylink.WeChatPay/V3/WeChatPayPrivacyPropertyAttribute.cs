using System;

namespace Essensoft.Paylink.WeChatPay.V3
{
    /// <summary>
    /// 标记指定属性为敏感信息
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class WeChatPayPrivacyPropertyAttribute : Attribute
    {
    }
}
