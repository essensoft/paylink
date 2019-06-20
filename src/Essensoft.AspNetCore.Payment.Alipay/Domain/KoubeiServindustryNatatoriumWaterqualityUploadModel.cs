using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryNatatoriumWaterqualityUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryNatatoriumWaterqualityUploadModel : AlipayObject
    {
        /// <summary>
        /// ISV的插件ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 游泳馆当前时间人数
        /// </summary>
        [JsonProperty("current_num")]
        public long CurrentNum { get; set; }

        /// <summary>
        /// 当前场馆内人数更新时间
        /// </summary>
        [JsonProperty("currentnum_update_time")]
        public string CurrentnumUpdateTime { get; set; }

        /// <summary>
        /// 外部ID,水质信息在ISV的系统中的主键,方便关联数据,非必填
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 浸脚消毒池游离性余氯是否合格,枚举(unqualified=不合格,qualified=合格)  ISV通过浸脚消毒池游离性余氯和浸脚消毒池游离性余氯标准算出
        /// </summary>
        [JsonProperty("footpool_cl_qualified")]
        public string FootpoolClQualified { get; set; }

        /// <summary>
        /// 浸脚消毒池游离性余氯,(单位:mg/L)  精确到小数点后两位,取值大于等于0
        /// </summary>
        [JsonProperty("footpool_cl_remain")]
        public string FootpoolClRemain { get; set; }

        /// <summary>
        /// 浸脚消毒池游离性余氯标准,方括号标识闭区间,圆括号表示开区间,第一个数字表示下限,第二个数字表示上限,数字精确到小数点后两位,数字取值大于等于0,且下限小于等于上限
        /// </summary>
        [JsonProperty("footpool_cl_remain_standard")]
        public string FootpoolClRemainStandard { get; set; }

        /// <summary>
        /// 游泳馆可容纳最大人数，为正整数
        /// </summary>
        [JsonProperty("limit_num")]
        public long LimitNum { get; set; }

        /// <summary>
        /// 泳池游离性余氯是否合格,枚举(unqualified=不合格,qualified=合格)  ISV通过泳池游离性余氯和泳池游离性余氯标准算出
        /// </summary>
        [JsonProperty("mainpool_cl_qualified")]
        public string MainpoolClQualified { get; set; }

        /// <summary>
        /// 泳池游离性余氯,(单位:mg/L)  精确到小数点后两位,取值大于等于0
        /// </summary>
        [JsonProperty("mainpool_cl_remain")]
        public string MainpoolClRemain { get; set; }

        /// <summary>
        /// 泳池游离性余氯标准,方括号标识闭区间,圆括号表示开区间,第一个数字表示下限,第二个数字表示上限,数字精确到小数点后两位,数字取值大于等于0,且下限小于等于上限
        /// </summary>
        [JsonProperty("mainpool_cl_remain_standard")]
        public string MainpoolClRemainStandard { get; set; }

        /// <summary>
        /// 游泳池容积(单位:吨), 精确到小数点后两位,大于0
        /// </summary>
        [JsonProperty("pool_volume")]
        public string PoolVolume { get; set; }

        /// <summary>
        /// 游泳池水质数据备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求ID,唯一的请求ID,用于幂等控制
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 游泳池换水量(单位:吨), 精确到小数点后两位,大于0
        /// </summary>
        [JsonProperty("water_change")]
        public string WaterChange { get; set; }

        /// <summary>
        /// 7日平均换水率(单位:%), 精确到小数点后两位,取值大于等于0,小于等于100
        /// </summary>
        [JsonProperty("water_change_percent")]
        public string WaterChangePercent { get; set; }

        /// <summary>
        /// 7日平均换水率是否合格,枚举(unqualified=不合格,qualified=合格)  ISV根据7天换水率和7天换水率标准计算得出
        /// </summary>
        [JsonProperty("water_change_qualified")]
        public string WaterChangeQualified { get; set; }

        /// <summary>
        /// 7日平均换水率标准,方括号表示闭区间,圆括号表示开区间,第一个数字表示下限,第二个数字表示上限,两个数字用英文逗号分隔,数字精确到小数点后两位,取值大于等于0小于等于100,且下限小于等于上限
        /// </summary>
        [JsonProperty("water_change_standard")]
        public string WaterChangeStandard { get; set; }

        /// <summary>
        /// 水质监测时间
        /// </summary>
        [JsonProperty("water_check_time")]
        public string WaterCheckTime { get; set; }

        /// <summary>
        /// 游泳池水的PH值,精确到小数点后两位
        /// </summary>
        [JsonProperty("water_ph")]
        public string WaterPh { get; set; }

        /// <summary>
        /// 游泳池水PH值是否合格,枚举(unqualified=不合格,qualified=合格)  ISV通过游泳池水PH值和PH值标准算出
        /// </summary>
        [JsonProperty("water_ph_qualified")]
        public string WaterPhQualified { get; set; }

        /// <summary>
        /// 游泳池水PH值标准,方括号表示闭区间,圆括号表示开区间,第一个数字表示下限,第二个数字表示上限,数字精确到小数点后两位,且下限小于等于上限
        /// </summary>
        [JsonProperty("water_ph_standard")]
        public string WaterPhStandard { get; set; }

        /// <summary>
        /// 水质是否合格,枚举(unqualified=不合格,qualified=合格)  ISV通过所有水质标准计算得出，全部合格才能合格
        /// </summary>
        [JsonProperty("water_qualified")]
        public string WaterQualified { get; set; }

        /// <summary>
        /// 当前水温(单位:℃),精确到小数点后两位
        /// </summary>
        [JsonProperty("water_temperature")]
        public string WaterTemperature { get; set; }

        /// <summary>
        /// 水温是否合格,枚举(unqualified=不合格,qualified=合格)  ISV根据当前水温和水温标准计算得出
        /// </summary>
        [JsonProperty("water_temperature_qualified")]
        public string WaterTemperatureQualified { get; set; }

        /// <summary>
        /// 水温标准,方括号标识闭区间,圆括号表示开区间,第一个数字表示下限,第二个数字表示下限,数字精确到小数点后两位,且下限小于等于上限,单位:℃
        /// </summary>
        [JsonProperty("water_temperature_standard")]
        public string WaterTemperatureStandard { get; set; }

        /// <summary>
        /// 水质更新时间,会根据这个时间给游泳馆店铺打标
        /// </summary>
        [JsonProperty("water_update_time")]
        public string WaterUpdateTime { get; set; }
    }
}
