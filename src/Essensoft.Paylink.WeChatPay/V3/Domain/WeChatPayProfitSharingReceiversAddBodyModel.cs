using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 资金应用 - 分账 - 添加分账接收方 - 请求JSON参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter8_1_8.shtml">分账 - 添加分账接收方API</a> - 最新更新时间：2021.05.11</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter8_1_8.shtml">分账(服务商) - 添加分账接收方API</a> - 最新更新时间：2021.05.11</para>
    /// </remarks>
    public class WeChatPayProfitSharingReceiversAddBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 子商户号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的子商户号，即分账的出资商户号。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        /// <remarks>
        /// 微信分配的商户appid、微信分配的服务商appid
        /// <para>示例值：wx8888888888888888</para>
        /// </remarks>
        [JsonPropertyName("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        /// <remarks>
        /// 微信分配的子商户公众账号ID，分账接收方类型包含PERSONAL_SUB_OPENID时必填。
        /// <para>示例值：wx8888888888888888</para>
        /// </remarks>
        [JsonPropertyName("sub_appid")]
        public string SubAppId { get; set; }

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
        /// 类型是MERCHANT_ID时，是商户号 类型是PERSONAL_OPENID时，是个人openid 类型是PERSONAL_SUB_OPENID时，是个人sub_openid
        /// <para>示例值: 86693852</para>
        /// </remarks>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 分账个人接收方姓名
        /// </summary>
        /// <remarks>
        /// 分账接收方类型是MERCHANT_ID时，是商户全称（必传），当商户是小微商户或个体户时，是开户人姓名 分账接收方类型是PERSONAL_OPENID时，是个人姓名（选传，传则校验） 分账接收方类型是PERSONAL_SUB_OPENID时，是个人姓名（选传，传则校验）
        /// 1、此字段需要加密，加密方法详见：敏感信息加密说明
        /// 2、使用微信支付平台证书中的公钥
        /// 3、使用RSAES-OAEP算法进行加密
        /// 4、将请求中HTTP头部的Wechatpay-Serial设置为证书序列号
        /// <para>示例值: hu89ohu89ohu89o</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 与分账方的关系类型
        /// </summary>
        /// <remarks>
        /// 商户与接收方的关系。本字段值为枚举：
        /// STORE：门店
        /// STAFF：员工
        /// STORE_OWNER：店主
        /// PARTNER：合作伙伴
        /// HEADQUARTER：总部
        /// BRAND：品牌方
        /// DISTRIBUTOR：分销商
        /// USER：用户
        /// SUPPLIER： 供应商
        /// CUSTOM：自定义
        /// <para>示例值: STORE</para>
        /// </remarks>
        [JsonPropertyName("relation_type")]
        public string RelationType { get; set; }

        /// <summary>
        /// 自定义的分账关系
        /// </summary>
        /// <remarks>
        /// 子商户与接收方具体的关系，本字段最多10个字。
        /// 当字段relation_type的值为CUSTOM时，本字段必填;
        /// 当字段relation_type的值不为CUSTOM时，本字段无需填写。
        /// <para>示例值：代理商</para>
        /// </remarks>
        [JsonPropertyName("custom_relation")]
        public string CustomRelation { get; set; }
    }
}
