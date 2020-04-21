using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdTamGetModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdTamGetModel : AlipayObject
    {
        /// <summary>
        /// business_id业务流水号+唯一+用于和OEM厂商服务端唯一确定一笔业务，OEM厂商服务端请求TA数据时的请求需要带上这个id+由支付宝项目ifaatam生成发给OEM厂商服务端，OEM厂商服务端在后续请求中带上+64位的唯一值
        /// </summary>
        [JsonPropertyName("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// condition客户端状态信息，记录如会话id等信息的字段+不唯一+由客户端上传给支付宝，支付宝服务端，再转发给OEM厂商服务端，OEM厂商服务端请求ta的时候带上这个字段信息+特殊说明：为业务未来发展预留的字段，内容可能有较大变动
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// ext_info+不唯一+JSON形式的map，包含关于ta摘要算法等信息+枚举值：BASE64_OVER_SHA256；BASE64_OVER_SHA512;BASE64_OVER_SM3+OEM厂商获取TA时放在入参里+缺省值为BASE64_OVER_SHA256
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// sp_aik_pub(OEM厂商服务端分配给服务商的公钥)+唯一+由OEM厂商服务端生成，OEM厂商服务端在请求ta文件时会带上这个公钥，用于支付宝加密对称密钥返回给OEM厂商服务端+示例值由于输入长度限制并非真实的公钥长度
        /// </summary>
        [JsonPropertyName("sp_aik_pub")]
        public string SpAikPub { get; set; }

        /// <summary>
        /// sp_id（service provider id）+唯一+由OEM厂商服务端分配给各个服务商（如支付宝），每个服务商有个固定的id+由OEM厂商服务端分配
        /// </summary>
        [JsonPropertyName("sp_id")]
        public string SpId { get; set; }

        /// <summary>
        /// ta_id(trusted application id，可信应用id)+不唯一+由客户端上传给支付宝服务端用于支付宝服务端确定下发的ta文件类型，传递给OEM厂商服务端tam，OEM厂商服务端请求ta文件会带上这个ta_id+生成方式由支付宝确定
        /// </summary>
        [JsonPropertyName("ta_id")]
        public string TaId { get; set; }

        /// <summary>
        /// ta_version（可信应用版本号）+不唯一+由客户端上传给支付宝服务端用于确认ta的版本信息，传递给OEM厂商服务端，OEM厂商服务端请求ta文件会带上这个版本信息ta_version+生成方式由支付宝确定
        /// </summary>
        [JsonPropertyName("ta_version")]
        public string TaVersion { get; set; }
    }
}
