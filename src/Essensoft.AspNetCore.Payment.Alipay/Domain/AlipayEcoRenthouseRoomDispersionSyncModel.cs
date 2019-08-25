using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRoomDispersionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseRoomDispersionSyncModel : AlipayObject
    {
        /// <summary>
        /// 阿里短号
        /// </summary>
        [JsonProperty("ali_short_num")]
        public string AliShortNum { get; set; }

        /// <summary>
        /// 户型-房  数值范围：1-26
        /// </summary>
        [JsonProperty("bedroom_count")]
        public long BedroomCount { get; set; }

        /// <summary>
        /// 可入住时间YYYY-MM-DD。大于今日，且小于等于185天
        /// </summary>
        [JsonProperty("checkin_time")]
        public string CheckinTime { get; set; }

        /// <summary>
        /// 小区同步请求号
        /// </summary>
        [JsonProperty("comm_req_id")]
        public string CommReqId { get; set; }

        /// <summary>
        /// 佣金
        /// </summary>
        [JsonProperty("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// 佣金类型（p：百分比，m：金额）
        /// </summary>
        [JsonProperty("commission_type")]
        public string CommissionType { get; set; }

        /// <summary>
        /// 小区Code和小区请求号必输入其一  小区Code,详见文档  http://ecopublic.oss-cn-hangzhou.aliyuncs.com/eco/tpmogo/CommunityInfos/CommunityInfos.xls
        /// </summary>
        [JsonProperty("community_code")]
        public string CommunityCode { get; set; }

        /// <summary>
        /// 费用说明
        /// </summary>
        [JsonProperty("fee_remark")]
        public string FeeRemark { get; set; }

        /// <summary>
        /// 公寓面积 数值范围：5.00㎡-300.00㎡，支持小数点后面2位
        /// </summary>
        [JsonProperty("flat_area")]
        public string FlatArea { get; set; }

        /// <summary>
        /// 门牌-栋（楼号）
        /// </summary>
        [JsonProperty("flat_building")]
        public string FlatBuilding { get; set; }

        /// <summary>
        /// 分散式合租公共区域物品配置，分散式整租不用设置  1:WIFI;3:热水器;4:洗衣机;5:冰箱;6:电视;7:微波炉;8:燃气灶;9:抽油烟机;10:电磁炉;14:沙发;
        /// </summary>
        [JsonProperty("flat_configs")]
        public List<string> FlatConfigs { get; set; }

        /// <summary>
        /// 门牌-单元
        /// </summary>
        [JsonProperty("flat_unit")]
        public string FlatUnit { get; set; }

        /// <summary>
        /// 所在楼层
        /// </summary>
        [JsonProperty("floor_count")]
        public long FloorCount { get; set; }

        /// <summary>
        /// 押金 数值范围：0-￥420000.00
        /// </summary>
        [JsonProperty("foregift_amount")]
        public string ForegiftAmount { get; set; }

        /// <summary>
        /// 免押金开始时间 YYYY-MM-dd
        /// </summary>
        [JsonProperty("free_begin_date")]
        public string FreeBeginDate { get; set; }

        /// <summary>
        /// 免押金结束时间 YYYY-MM-dd
        /// </summary>
        [JsonProperty("free_end_date")]
        public string FreeEndDate { get; set; }

        /// <summary>
        /// 通过"文件上传"接口返回的房源图片url路径。房间照片可录入0~10张,目前仅支持jpg、png、jpeg格式
        /// </summary>
        [JsonProperty("images")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 房源描述
        /// </summary>
        [JsonProperty("intro")]
        public string Intro { get; set; }

        /// <summary>
        /// 可签约至YYYY-MM-DD
        /// </summary>
        [JsonProperty("max_lease_time")]
        public string MaxLeaseTime { get; set; }

        /// <summary>
        /// 多少天起可租
        /// </summary>
        [JsonProperty("min_rent_days")]
        public long MinRentDays { get; set; }

        /// <summary>
        /// 其它费用
        /// </summary>
        [JsonProperty("other_amount")]
        public List<EcoRenthouseOtherAmount> OtherAmount { get; set; }

        /// <summary>
        /// 管家姓名
        /// </summary>
        [JsonProperty("owners_name")]
        public string OwnersName { get; set; }

        /// <summary>
        /// 管家手机号码，必须为400开头
        /// </summary>
        [JsonProperty("owners_tel")]
        public string OwnersTel { get; set; }

        /// <summary>
        /// 户型-厅   数值范围：0-10
        /// </summary>
        [JsonProperty("parlor_count")]
        public long ParlorCount { get; set; }

        /// <summary>
        /// 付款方式-付   1：付一，2：付二
        /// </summary>
        [JsonProperty("pay_type")]
        public long PayType { get; set; }

        /// <summary>
        /// 付款方式列表，包括上述单独传递的付款方式。如果2种都传递，默认覆盖单独传递的付款方式。
        /// </summary>
        [JsonProperty("pay_type_list")]
        public List<EcoDisRenthousepayTypeList> PayTypeList { get; set; }

        /// <summary>
        /// 出租状态 数值范围：1未租、2已租
        /// </summary>
        [JsonProperty("rent_status")]
        public long RentStatus { get; set; }

        /// <summary>
        /// 出租类型 1：整租，2：合租
        /// </summary>
        [JsonProperty("rent_type")]
        public long RentType { get; set; }

        /// <summary>
        /// 租金 数值范围：￥100.00 - ￥35000.00 ，支持小数点后面2位
        /// </summary>
        [JsonProperty("room_amount")]
        public string RoomAmount { get; set; }

        /// <summary>
        /// 房间面积 数值范围：5.00㎡-300.00㎡，支持小数点后面2位
        /// </summary>
        [JsonProperty("room_area")]
        public string RoomArea { get; set; }

        /// <summary>
        /// KA内部存储的房源编号
        /// </summary>
        [JsonProperty("room_code")]
        public long RoomCode { get; set; }

        /// <summary>
        /// 分散式房间物品配置：  分散式整租房间配置  2:空调;3:热水器;4:洗衣机;5:冰箱;6:电视;7:微波炉;8:燃气灶;9:抽油烟机;10:电磁炉;11:床;11:WIFI;12:书桌;13:衣柜;14:沙发;15:阳台;  分散式合租房间配置  2:空调;6:电视;11:床;12:书桌;13:衣柜;15:阳台;16:独卫;
        /// </summary>
        [JsonProperty("room_configs")]
        public List<string> RoomConfigs { get; set; }

        /// <summary>
        /// 分散式合租房间内对应每个卧室朝向  根据rent_type区分是否必填，合租必填，整租否。
        /// </summary>
        [JsonProperty("room_face")]
        public long RoomFace { get; set; }

        /// <summary>
        /// 分散式合租房间内对应每个卧室名称。A_Z字母之一表示。  根据rent_type区分是否必填，合租必填，整租否。
        /// </summary>
        [JsonProperty("room_name")]
        public string RoomName { get; set; }

        /// <summary>
        /// 门牌-室
        /// </summary>
        [JsonProperty("room_num")]
        public string RoomNum { get; set; }

        /// <summary>
        /// 房源初始上下架状态  上架状态租房平台会展示该房间信息，下架状态反之
        /// </summary>
        [JsonProperty("room_status")]
        public long RoomStatus { get; set; }

        /// <summary>
        /// 房源对应的店铺编号
        /// </summary>
        [JsonProperty("room_store_no")]
        public string RoomStoreNo { get; set; }

        /// <summary>
        /// 户型-卫   数值范围：0-10
        /// </summary>
        [JsonProperty("toilet_count")]
        public long ToiletCount { get; set; }

        /// <summary>
        /// 房屋总楼层
        /// </summary>
        [JsonProperty("total_floor_count")]
        public string TotalFloorCount { get; set; }
    }
}
