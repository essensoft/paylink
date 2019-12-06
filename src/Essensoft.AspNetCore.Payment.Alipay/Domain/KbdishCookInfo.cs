using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookInfo Data Structure.
    /// </summary>
    public class KbdishCookInfo : AlipayObject
    {
        /// <summary>
        /// 区域
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 渠道    eatin堂食，takeout外卖,paipai 扫码,kbb2c 口碑点餐
        /// </summary>
        [JsonPropertyName("cook_channel")]
        public string CookChannel { get; set; }

        /// <summary>
        /// 扩展字典,json串
        /// </summary>
        [JsonPropertyName("cook_ext_content")]
        public string CookExtContent { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱名称
        /// </summary>
        [JsonPropertyName("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonPropertyName("cook_version")]
        public string CookVersion { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 时间区间日期结束
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间区间截止 闭区间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 数据的创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 数据的修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 口碑菜谱明细
        /// </summary>
        [JsonPropertyName("kb_cook_detail_list")]
        public List<KbdishCookDetailInfo> KbCookDetailList { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 时间约束类型 forever:永久;  week:按周，每周周几 month:按月,每月几号.  如果操作的是菜谱，非空必传。如果是操作门店或者挂明细，可为空
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 时间控制值,如果选的week, 值 1,2,3,4 ; 如果选择month 1,11,31 ; 如果选择永久，为空
        /// </summary>
        [JsonPropertyName("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 菜谱描述
        /// </summary>
        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// 门店列表
        /// </summary>
        [JsonPropertyName("shop_list")]
        public List<string> ShopList { get; set; }

        /// <summary>
        /// yazuo,meituan,ele获取，新增的时候必输。
        /// </summary>
        [JsonPropertyName("source_from")]
        public string SourceFrom { get; set; }

        /// <summary>
        /// 控制的日期区间开始
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间控制 到分  闭区间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("update_user")]
        public string UpdateUser { get; set; }
    }
}
