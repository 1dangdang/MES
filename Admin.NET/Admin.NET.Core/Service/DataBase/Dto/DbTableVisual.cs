﻿// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Core.Service;

public class VisualDb
{
    public string ConfigId { get; set; }
    public string DbNickName { get; set; }
}

/// <summary>
/// 库表可视化
/// </summary>
public class VisualDbTable
{
    public List<VisualTable> VisualTableList { get; set; }

    public List<VisualColumn> VisualColumnList { get; set; }

    public List<ColumnRelation> ColumnRelationList { get; set; }
}

public class VisualTable
{
    public string TableName { get; set; }

    public string TableComents { get; set; }

    public int X { get; set; }

    public int Y { get; set; }
}

public class VisualColumn
{
    public string TableName { get; set; }

    public string ColumnName { get; set; }

    public string DataType { get; set; }

    public string DataLength { get; set; }

    public string ColumnDescription { get; set; }
}

public class ColumnRelation
{
    public string SourceTableName { get; set; }

    public string SourceColumnName { get; set; }

    public string Type { get; set; }

    public string TargetTableName { get; set; }

    public string TargetColumnName { get; set; }
}