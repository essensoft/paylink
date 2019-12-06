using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeOrderConsultModel Data Structure.
    /// </summary>
    public class KoubeiTradeOrderConsultModel : AlipayObject
    {
        /// <summary>
        /// 用户设备信息,通过钱包容器提供的JSAPI接口获取，  一、接口使用方法：  AlipayJSBridge.call('getO2ODeviceToken', {                  appName: 'kb_isv_110229',                  appKey:'98y6VvdaDLpoqWZw'              },              function (result) {                   }          );      });  二、result数据结构：   1、调用失败： {"error":xxx,"errorMessage":"xxx"}     2、调用成功： {'appToken':'xxxssajkjkjkxdkwqkqwb'}
        /// </summary>
        [JsonPropertyName("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 商品明细列表。注意：单品总金额不能大于订单金额
        /// </summary>
        [JsonPropertyName("goods_info")]
        public List<GoodsInfo> GoodsInfo { get; set; }

        /// <summary>
        /// 唯一请求id，开放者请确保每次请求的唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 支付宝门店编号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单总金额，单位元，精确到小数点后两位，取值范围[0.01,999999999]  如果同时传入了【不可打折金额】，【订单总金额】两者，则必须满足【不可打折金额】<=【订单总金额】
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额，单位为元，精确到小数点后两位，取值范围[0,999999999]  如果同时传入了【不可打折金额】、【订单总金额】，则必须满足【不可打折金额】<=【订单总金额】
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
