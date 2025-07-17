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
/// 工艺路线表
/// </summary>
[SugarTable(null, "工艺路线表")]
[SysTable]
public class ProcessRoute : EntityBaseDel
{
    /// <summary>
    /// 工艺路线编号
    /// </summary>
    public string ProcessRouteCode { get; set; }

    /// <summary>
    /// 系统编号开关状态
    /// </summary>
    public bool IsSystemCode { get; set; }

    /// <summary>
    /// 工艺路线名称
    /// </summary>
    public string ProcessRouteName { get; set; }

    /// <summary>
    /// 工艺路线状态
    /// </summary>
    public bool Status { get; set; }

    /// <summary>
    /// 工艺路线的说明信息，对应表单中的说明输入框
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 工艺路线的备注信息，对应表单中的备注输入框
    /// </summary>
    public string Remarks { get; set; }
    /// <summary>
    /// 工序步骤
    /// </summary>
    public string ProcessSteps { get; set; }
    /// <summary>
    /// 产品
    /// </summary>
    public string Products { get; set; }
}
