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
/// 工序管理
/// </summary>
[SugarTable(null, "工序管理表")]
[SysTable]
public class ProcessStep
{
    /// <summary>
    /// 工序主键Id213231213
    /// </summary>
    public int ProcessStepId { get; set; }
    public string ProcessName { get; set; }   // 工序名称
    public string ProcessCode { get; set; }   // 工序编号
    public bool Status { get; set; }        // 状态（启用/禁用）
    public string Description { get; set; }   // 工序说明
    public string Remark { get; set; }        // 备注
}
