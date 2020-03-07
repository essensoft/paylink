using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayConsultModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderPayConsultModel : AlipayObject
    {
        /// <summary>
        /// 用户设备信息,通过钱包容器提供的JSAPI接口获取，  一、接口使用方法：  AlipayJSBridge.call('getO2ODeviceToken', {                  appName: 'kb_isv_110229',                  appKey:'98y6VvdaDLpoqWZw'              },              function (result) {                   }          );      });  二、result数据结构：   1、调用失败： {"error":xxx,"errorMessage":"xxx"}     2、调用成功： {'appToken':'xxxssajkjkjkxdkwqkqwb'}
        /// </summary>
        [JsonPropertyName("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 菜明细列表，size>=1 && size <=100
        /// </summary>
        [JsonPropertyName("dish_details")]
        public List<KbPosOrderDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 是否享受会员价。如果为true，菜明细里面会按照会员价（没有改价情况下）作为单品价格咨询单品券优惠
        /// </summary>
        [JsonPropertyName("member_flag")]
        public bool MemberFlag { get; set; }

        /// <summary>
        /// 其他费用
        /// </summary>
        [JsonPropertyName("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 打包费
        /// </summary>
        [JsonPropertyName("packing_amount")]
        public string PackingAmount { get; set; }

        /// <summary>
        /// 唯一请求id，开放者请确保每次请求的唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        [JsonPropertyName("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 付款总金额。需要确保：  1、付款总金额≤菜明细需付款金额总和+服务费+打包费+其他费用；  2、付款总金额≥菜明细需付款金额总和。  注：如果存在整单优惠场景，付款总金额不满足上述2条件，建议走单品改价优惠模式，修改单个菜品的金额达到优惠目的。
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
