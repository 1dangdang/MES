// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

using MapsterMapper;

namespace Admin.NET.Core;

public static class RepositoryExtension
{
    /// <summary>
    /// 实体假删除 _rep.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int FakeDelete<T>(this ISugarRepository repository, T entity) where T : EntityBaseDel, new()
    {
        return repository.Context.FakeDelete(entity);
    }

    /// <summary>
    /// 实体假删除 db.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int FakeDelete<T>(this ISqlSugarClient db, T entity) where T : EntityBaseDel, new()
    {
        return db.Updateable(entity).AS().ReSetValue(x => { x.IsDelete = true; })
            .IgnoreColumns(ignoreAllNullColumns: true)
            .EnableDiffLogEvent()   // 记录差异日志
            .UpdateColumns(x => new { x.IsDelete, x.UpdateTime, x.UpdateUserId })  // 允许更新的字段-AOP拦截自动设置UpdateTime、UpdateUserId
            .ExecuteCommand();
    }

    /// <summary>
    /// 实体集合批量假删除 _rep.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int FakeDelete<T>(this ISugarRepository repository, List<T> entity) where T : EntityBaseDel, new()
    {
        return repository.Context.FakeDelete(entity);
    }

    /// <summary>
    /// 实体集合批量假删除 db.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int FakeDelete<T>(this ISqlSugarClient db, List<T> entity) where T : EntityBaseDel, new()
    {
        return db.Updateable(entity).AS().ReSetValue(x => { x.IsDelete = true; })
            .IgnoreColumns(ignoreAllNullColumns: true)
            .EnableDiffLogEvent()   // 记录差异日志
            .UpdateColumns(x => new { x.IsDelete, x.UpdateTime, x.UpdateUserId })  // 允许更新的字段-AOP拦截自动设置UpdateTime、UpdateUserId
            .ExecuteCommand();
    }

    /// <summary>
    /// 实体假删除异步 _rep.FakeDeleteAsync(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> FakeDeleteAsync<T>(this ISugarRepository repository, T entity) where T : EntityBaseDel, new()
    {
        return repository.Context.FakeDeleteAsync(entity);
    }

    /// <summary>
    /// 实体假删除 db.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> FakeDeleteAsync<T>(this ISqlSugarClient db, T entity) where T : EntityBaseDel, new()
    {
        return db.Updateable(entity).AS().ReSetValue(x => { x.IsDelete = true; })
            .IgnoreColumns(ignoreAllNullColumns: true)
            .EnableDiffLogEvent()   // 记录差异日志
            .UpdateColumns(x => new { x.IsDelete, x.UpdateTime, x.UpdateUserId })  // 允许更新的字段-AOP拦截自动设置UpdateTime、UpdateUserId
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 实体集合批量假删除异步 _rep.FakeDeleteAsync(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> FakeDeleteAsync<T>(this ISugarRepository repository, List<T> entity) where T : EntityBaseDel, new()
    {
        return repository.Context.FakeDeleteAsync(entity);
    }

    /// <summary>
    /// 实体集合批量假删除 db.FakeDelete(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> FakeDeleteAsync<T>(this ISqlSugarClient db, List<T> entity) where T : EntityBaseDel, new()
    {
        return db.Updateable(entity).AS().ReSetValue(x => { x.IsDelete = true; })
            .IgnoreColumns(ignoreAllNullColumns: true)
            .EnableDiffLogEvent()   // 记录差异日志
            .UpdateColumns(x => new { x.IsDelete, x.UpdateTime, x.UpdateUserId })  // 允许更新的字段-AOP拦截自动设置UpdateTime、UpdateUserId
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 排序方式(默认降序)
    /// </summary>
    /// <param name="queryable"></param>
    /// <param name="pageInput"> </param>
    /// <param name="prefix"> </param>
    /// <param name="defaultSortField"> 默认排序字段 </param>
    /// <param name="descSort"> 是否降序 </param>
    /// <returns> </returns>
    public static ISugarQueryable<T> OrderBuilder<T>(this ISugarQueryable<T> queryable, BasePageInput pageInput, string prefix = "", string defaultSortField = "Id", bool descSort = true)
    {
        var iSqlBuilder = InstanceFactory.GetSqlBuilderWithContext(queryable.Context);

        // 约定默认每张表都有Id排序
        var orderStr = string.IsNullOrWhiteSpace(defaultSortField) ? "" : $"{prefix}{iSqlBuilder.GetTranslationColumnName(defaultSortField)}" + (descSort ? " Desc" : " Asc");

        TypeAdapterConfig typeAdapterConfig = new();
        typeAdapterConfig.ForType<T, BasePageInput>().IgnoreNullValues(true);
        Mapper mapper = new(typeAdapterConfig); // 务必将mapper设为单实例
        var nowPagerInput = mapper.Map<BasePageInput>(pageInput);
        // 排序是否可用-排序字段为非空才启用排序，排序顺序默认为倒序
        if (!string.IsNullOrEmpty(nowPagerInput.Field))
        {
            nowPagerInput.Field = Regex.Replace(nowPagerInput.Field, @"[\s;()\-'@=/%]", ""); //过滤掉一些关键字符防止构造特殊SQL语句注入
            var orderByDbName = queryable.Context.EntityMaintenance.GetDbColumnName<T>(nowPagerInput.Field);//防止注入，类中只要不存在属性名就会报错
            orderStr = $"{prefix}{iSqlBuilder.GetTranslationColumnName(orderByDbName)} {(string.IsNullOrEmpty(nowPagerInput.Order) || nowPagerInput.Order.Equals(nowPagerInput.DescStr, StringComparison.OrdinalIgnoreCase) ? "Desc" : "Asc")}";
        }
        return queryable.OrderByIF(!string.IsNullOrWhiteSpace(orderStr), orderStr);
    }

    /// <summary>
    /// 更新实体并记录差异日志 _rep.UpdateWithDiffLog(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <param name="ignoreAllNullColumns"></param>
    /// <returns></returns>
    public static int UpdateWithDiffLog<T>(this ISugarRepository repository, T entity, bool ignoreAllNullColumns = true) where T : EntityBase, new()
    {
        return repository.Context.UpdateWithDiffLog(entity, ignoreAllNullColumns);
    }

    /// <summary>
    /// 更新实体并记录差异日志 _rep.UpdateWithDiffLog(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <param name="ignoreAllNullColumns"></param>
    /// <returns></returns>
    public static int UpdateWithDiffLog<T>(this ISqlSugarClient db, T entity, bool ignoreAllNullColumns = true) where T : EntityBase, new()
    {
        return db.Updateable(entity).AS()
            .IgnoreColumns(ignoreAllNullColumns: ignoreAllNullColumns)
            .EnableDiffLogEvent()
            .ExecuteCommand();
    }

    /// <summary>
    /// 更新实体并记录差异日志 _rep.UpdateWithDiffLogAsync(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <param name="ignoreAllNullColumns"></param>
    /// <returns></returns>
    public static Task<int> UpdateWithDiffLogAsync<T>(this ISugarRepository repository, T entity, bool ignoreAllNullColumns = true) where T : EntityBase, new()
    {
        return repository.Context.UpdateWithDiffLogAsync(entity, ignoreAllNullColumns);
    }

    /// <summary>
    /// 更新实体并记录差异日志 _rep.UpdateWithDiffLogAsync(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <param name="ignoreAllNullColumns"></param>
    /// <returns></returns>
    public static Task<int> UpdateWithDiffLogAsync<T>(this ISqlSugarClient db, T entity, bool ignoreAllNullColumns = true) where T : EntityBase, new()
    {
        return db.Updateable(entity)
            .IgnoreColumns(ignoreAllNullColumns: ignoreAllNullColumns)
            .EnableDiffLogEvent()
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 新增实体并记录差异日志 _rep.InsertWithDiffLog(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int InsertWithDiffLog<T>(this ISugarRepository repository, T entity) where T : EntityBase, new()
    {
        return repository.Context.InsertWithDiffLog(entity);
    }

    /// <summary>
    /// 新增实体并记录差异日志 _rep.InsertWithDiffLog(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static int InsertWithDiffLog<T>(this ISqlSugarClient db, T entity) where T : EntityBase, new()
    {
        return db.Insertable(entity).AS().EnableDiffLogEvent().ExecuteCommand();
    }

    /// <summary>
    /// 新增实体并记录差异日志 _rep.InsertWithDiffLogAsync(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="repository"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> InsertWithDiffLogAsync<T>(this ISugarRepository repository, T entity) where T : EntityBase, new()
    {
        return repository.Context.InsertWithDiffLogAsync(entity);
    }

    /// <summary>
    /// 新增实体并记录差异日志 _rep.InsertWithDiffLog(entity)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="db"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Task<int> InsertWithDiffLogAsync<T>(this ISqlSugarClient db, T entity) where T : EntityBase, new()
    {
        return db.Insertable(entity).AS().EnableDiffLogEvent().ExecuteCommandAsync();
    }

    /// <summary>
    /// 多库查询
    /// </summary>
    /// <param name="queryable"></param>
    /// <returns> </returns>
    public static ISugarQueryable<T> AS<T>(this ISugarQueryable<T> queryable)
    {
        var info = GetTableInfo<T>();
        return queryable.AS<T>($"{info.Item1}.{info.Item2}");
    }

    /// <summary>
    /// 多库查询
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="queryable"></param>
    /// <returns></returns>
    public static ISugarQueryable<T, T2> AS<T, T2>(this ISugarQueryable<T, T2> queryable)
    {
        var info = GetTableInfo<T2>();
        return queryable.AS<T2>($"{info.Item1}.{info.Item2}");
    }

    /// <summary>
    /// 多库更新
    /// </summary>
    /// <param name="updateable"></param>
    /// <returns> </returns>
    public static IUpdateable<T> AS<T>(this IUpdateable<T> updateable) where T : EntityBase, new()
    {
        var info = GetTableInfo<T>();
        return updateable.AS($"{info.Item1}.{info.Item2}");
    }

    /// <summary>
    /// 多库新增
    /// </summary>
    /// <param name="insertable"></param>
    /// <returns> </returns>
    public static IInsertable<T> AS<T>(this IInsertable<T> insertable) where T : EntityBase, new()
    {
        var info = GetTableInfo<T>();
        return insertable.AS($"{info.Item1}.{info.Item2}");
    }

    /// <summary>
    /// 多库删除
    /// </summary>
    /// <param name="deleteable"></param>
    /// <returns> </returns>
    public static IDeleteable<T> AS<T>(this IDeleteable<T> deleteable) where T : EntityBase, new()
    {
        var info = GetTableInfo<T>();
        return deleteable.AS($"{info.Item1}.{info.Item2}");
    }

    /// <summary>
    /// 根据实体类型获取表信息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    private static Tuple<string, string> GetTableInfo<T>()
    {
        var entityType = typeof(T);
        var attr = entityType.GetCustomAttribute<TenantAttribute>();
        var configId = attr == null ? SqlSugarConst.MainConfigId : attr.configId.ToString();
        var tableName = entityType.GetCustomAttribute<SugarTable>().TableName;
        return new Tuple<string, string>(configId, tableName);
    }

    /// <summary>
    /// 禁用过滤器-适用于更新和删除操作（只对当前请求有效，禁止使用异步）
    /// </summary>
    /// <param name="repository"></param>
    /// <param name="action">禁止异步</param>
    /// <returns></returns>
    public static void RunWithoutFilter(this ISugarRepository repository, Action action)
    {
        repository.Context.QueryFilter.ClearAndBackup(); // 清空并备份过滤器
        action.Invoke();
        repository.Context.QueryFilter.Restore(); // 还原过滤器

        // 用例
        //_rep.RunWithoutFilter(() =>
        //{
        //    执行更新或者删除
        //    禁止使用异步函数
        //});
    }

    /// <summary>
    /// 忽略租户
    /// </summary>
    /// <param name="queryable"></param>
    /// <param name="ignore">是否忽略 默认true</param>
    /// <returns> </returns>
    public static ISugarQueryable<T> IgnoreTenant<T>(this ISugarQueryable<T> queryable, bool ignore = true)
    {
        return ignore ? queryable.ClearFilter<ITenantIdFilter>() : queryable;
    }

    /// <summary>
    /// 只更新某些列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    /// <param name="updateable"></param>
    /// <returns></returns>
    public static IUpdateable<T> OnlyUpdateColumn<T, R>(this IUpdateable<T> updateable) where T : EntityBase, new() where R : class, new()
    {
        if (updateable.UpdateBuilder.UpdateColumns == null)
            updateable.UpdateBuilder.UpdateColumns = new List<string>();

        foreach (PropertyInfo info in typeof(R).GetProperties())
        {
            // 判断是否是相同属性
            if (typeof(T).GetProperty(info.Name) != null)
                updateable.UpdateBuilder.UpdateColumns.Add(info.Name);
        }
        return updateable;
    }

    /// <summary>
    /// 导航只更新（主表）某些列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="R"></typeparam>
    /// <param name="t"></param>
    /// <param name="r"></param>
    /// <returns></returns>
    public static UpdateNavRootOptions OnlyNavUpdateColumn<T, R>(this T t, R r)
    {
        UpdateNavRootOptions uNOption = new UpdateNavRootOptions();
        var updateColumns = new List<string>();

        foreach (PropertyInfo info in r.GetType().GetProperties())
        {
            //判断是否是相同属性
            PropertyInfo pro = t.GetType().GetProperty(info.Name);
            var attr = pro.GetCustomAttribute<SugarColumn>();
            if (pro != null && attr != null && !attr.IsPrimaryKey)
                updateColumns.Add(info.Name);
        }
        uNOption.UpdateColumns = updateColumns.ToArray();
        return uNOption;
    }

    /// <summary>
    /// 批量列表in查询
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <param name="queryable"></param>
    /// <param name="exp"></param>
    /// <param name="queryList"></param>
    /// <param name="stoppingToken"></param>
    /// <returns></returns>
    public static async Task<List<T1>> BulkListQuery<T1, T2>(this ISugarQueryable<T1> queryable,
            Expression<Func<T1, SingleColumnEntity<T2>, bool>> exp,
            IEnumerable<T2> queryList,
            CancellationToken stoppingToken) where T1 : class, new()
    {
        // 创建临时表 (用真表兼容性好，表名随机)
        var tableName = "Temp" + SnowFlakeSingle.Instance.NextId();
        try
        {
            var type = queryable.Context.DynamicBuilder().CreateClass(tableName, new SugarTable())
                .CreateProperty("ColumnName", typeof(string), new SugarColumn() { IsPrimaryKey = true }) // 主键不要自增
                .BuilderType();
            // 创建表
            queryable.Context.CodeFirst.InitTables(type);
            var insertData = queryList.Select(it => new SingleColumnEntity<T2>() { ColumnName = it }).ToList();
            // 插入临时表
            queryable.Context.Fastest<SingleColumnEntity<T2>>()
                .AS(tableName)
                .BulkCopy(insertData);
            var queryTemp = queryable.Context.Queryable<SingleColumnEntity<T2>>()
                .AS(tableName);

            var systemData = await queryable
                .InnerJoin(queryTemp, exp)
                .ToListAsync(stoppingToken);

            queryable.Context.DbMaintenance.DropTable(tableName);
            return systemData;
        }
        catch (Exception error)
        {
            queryable.Context.DbMaintenance.DropTable(tableName);
            throw Oops.Oh(error);
        }
    }
}