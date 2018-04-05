using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.QPay
{
    public abstract class QPayResponse : QPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [JsonIgnore]
        public QPayDictionary Parameters { get; internal set; }
    }
}
