// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.NET.Core.Entity.MesEntity;
/// <summary>
/// 产品管理表
/// </summary>
[SugarTable(null, "产品管理表")]
[SysTable]
public class Product : EntityBaseDel
{

    /// <summary>
    /// 产品编号（唯一标识）
    /// </summary>
    public string ProductCode { get; set; }

    /// <summary>
    /// 是否设置系统编号（0/1）
    /// </summary>
    public bool IsSystemCode { get; set; }

    /// <summary>
    /// 产品名称
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// 产品规格型号
    /// </summary>
    public string Specification { get; set; }

    /// <summary>
    /// 产品计量单位（个/件/箱等）
    /// </summary>
    public string Unit { get; set; }

    /// <summary>
    /// 产品类型（下拉选项值）
    /// </summary>
    public string ProductType { get; set; }

    /// <summary>
    /// 产品属性（下拉选项值）
    /// </summary>
    public string ProductAttribute { get; set; }

    /// <summary>
    /// 产品分类（下拉选项值）
    /// </summary>
    public string ProductCategory { get; set; }

    /// <summary>
    /// 产品状态（启用/禁用）
    /// </summary>
    public bool Status { get; set; }
    /// <summary>
    /// 有效期限数值
    /// </summary>
    public int? ValidPeriodValue { get; set; }

    /// <summary>
    /// 有效期限单位（天/月/年）
    /// </summary>
    public string ValidPeriodUnit { get; set; }

    /// <summary>
    /// 有效期预警天数
    /// </summary>
    public int? AlarmDays { get; set; }

    /// <summary>
    /// 库存上限
    /// </summary>
    public decimal? StockUpperLimit { get; set; }

    /// <summary>
    /// 库存下限
    /// </summary>
    public decimal? StockLowerLimit { get; set; }
    /// <summary>
    /// 产品采购价格
    /// </summary>
    public decimal? PurchasePrice { get; set; }
    /// <summary>
    /// 产品销售价格
    /// </summary>
    public decimal? SalesPrice { get; set; }
    /// <summary>
    /// 产品备注信息
    /// </summary>
    public string Remarks { get; set; }
    /// <summary>
    /// 产品图片存储路径
    /// </summary>
    public string ProductImage { get; set; }
}
