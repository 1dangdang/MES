﻿// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
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
/// 生产线管理表
/// </summary>
[SugarTable(null, "生产线管理表")]
[SysTable]
public class ProductionLine
{
    /// <summary>
    /// 生产线管理主键Id123312123
    /// </summary>
    public int ProductionLineId { get; set; }

    /// <summary>
    /// 生产线编号
    /// </summary>
    public string ProductionLineCode { get; set; }

    /// <summary>
    /// 生产线名称
    /// </summary>
    public string ProductionLineName { get; set; }

    /// <summary>
    /// 生产线类型
    /// </summary>
    public string ProductionLineType { get; set; }

    /// <summary>
    /// 所在车间
    /// </summary>
    public int WorkShopId { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public bool Status { get; set; }
    /// <summary>
    /// 备注
    /// </summary>
    public string Remarks { get; set; }
}
