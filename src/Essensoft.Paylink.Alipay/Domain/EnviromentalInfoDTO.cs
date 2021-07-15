using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// EnviromentalInfoDTO Data Structure.
    /// </summary>
    public class EnviromentalInfoDTO : AlipayObject
    {
        /// <summary>
        /// environmental_info不为空时,必填; 环保类型:A:减塑/不使用购 物袋;B 无纸质小票;C:直饮水;D :酒店六小件发放(减塑)E:酒 店-减碳-不洗涤;F:景区订单; G:高校订单;H:充电宝订单:I:物流订单
        /// </summary>
        [JsonPropertyName("environmental")]
        public string Environmental { get; set; }

        /// <summary>
        /// environmental_info不为空时,必填; 环保行为内容字典值: 减塑/不使用购物袋:huanbaojiansu;  无纸质小票(电子小票):dianzixiaopiao; 直饮水:zhiyinshui;   酒店六小件发放（减塑）:待定； 减碳-酒店不洗涤:待定;   景区订单-扫码购票:saomagoupiao;   高校订单:待定; 充电宝订单:chongdianbao; 物流订单:wangshangjijian
        /// </summary>
        [JsonPropertyName("environmental_ext")]
        public string EnvironmentalExt { get; set; }
    }
}
