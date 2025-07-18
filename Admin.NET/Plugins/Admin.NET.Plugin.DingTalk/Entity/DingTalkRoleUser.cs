// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Plugin.DingTalk;

/// <summary>
/// 钉钉角色信息
/// </summary>
[SugarTable(null, "钉钉角色表")]
public class DingTalkRoleUser : EntityBaseDel
{
    /// <summary>
    /// 钉钉用户id
    /// </summary>
    [SugarColumn(ColumnDescription = "钉钉用户id", Length = 64)]
    [Required, MaxLength(64)]
    public virtual string? DingTalkUserId { get; set; }

    /// <summary>
    /// 角色组id
    /// </summary>
    [SugarColumn(ColumnDescription = "角色组id")]
    [Required]
    public virtual long groupId { get; set; }

    /// <summary>
    /// 角色组名称
    /// </summary>
    [SugarColumn(ColumnDescription = "角色组名", Length = 64)]
    [MaxLength(64)]
    public string? groupName { get; set; }

    /// <summary>
    /// 角色id
    /// </summary>
    [SugarColumn(ColumnDescription = "角色id")]
    [Required]
    public virtual long roleId { get; set; }

    /// <summary>
    /// 角色名
    /// </summary>
    [SugarColumn(ColumnDescription = "角色名", Length = 64)]
    [MaxLength(64)]
    public string? roleName { get; set; }
}