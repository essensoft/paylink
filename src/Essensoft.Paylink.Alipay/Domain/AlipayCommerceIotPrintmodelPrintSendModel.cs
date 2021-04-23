using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotPrintmodelPrintSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotPrintmodelPrintSendModel : AlipayObject
    {
        /// <summary>
        /// 服务调用上下文
        /// </summary>
        [JsonPropertyName("context")]
        public ServiceModelContext Context { get; set; }

        /// <summary>
        /// 打印服务调用内容
        /// </summary>
        [JsonPropertyName("print_message")]
        public PrintMessageVO PrintMessage { get; set; }
    }
}
