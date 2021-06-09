using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 分账接收方对象
    /// </summary>
    public class Receiver : WeChatPayObject
    {
        /// <summary>
        /// 分账接收方类型
        /// </summary>
        /// <remarks>
        /// 1、MERCHANT_ID：商户号
        /// 2、PERSONAL_OPENID：个人openid（由父商户APPID转换得到）
        /// 3、PERSONAL_SUB_OPENID: 个人sub_openid（由子商户APPID转换得到）
        /// <para>示例值: MERCHANT_ID</para>
        /// </remarks>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 分账接收方帐号
        /// </summary>
        /// <remarks>
        /// 1、分账接收方类型为MERCHANT_ID时，分账接收方账号为商户号
        /// 2、分账接收方类型为PERSONAL_OPENID时，分账接收方账号为个人openid
        /// 3、分账接收方类型为
        /// PERSONAL_SUB_OPENID时，分账接收方账号为个人sub_openid
        /// <para>示例值: 86693852</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账个人接收方姓名
        /// </summary>
        /// <remarks>
        /// 可选项，在接收方类型为个人的时可选填，若有值，会检查与 name 是否实名匹配，不匹配会拒绝分账请求
        /// 1、分账接收方类型是PERSONAL_OPENID或PERSONAL_SUB_OPENID时，是个人姓名的密文（选传，传则校验） 此字段的加密方法详见：敏感信息加密说明
        /// 2、使用微信支付平台证书中的公钥
        /// 3、使用RSAES-OAEP算法进行加密
        /// 4、将请求中HTTP头部的Wechatpay-Serial设置为证书序列号
        /// <para>示例值: hu89ohu89ohu89o</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 分账动账金额
        /// </summary>
        /// <remarks>
        /// 分账动账金额，单位为分，只能为整数
        /// <para>示例值: 888</para>
        /// </remarks>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 分账/回退描述
        /// </summary>
        /// <remarks>
        /// 分账/回退描述
        /// <para>示例值: 运费/交易分账/及时奖励</para>
        /// </remarks>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
