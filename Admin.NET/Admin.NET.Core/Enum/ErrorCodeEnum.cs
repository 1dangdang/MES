// Admin.NET 项目的版权、商标、专利和其他相关权利均受相应法律法规的保护。使用本项目应遵守相关法律法规和许可证的要求。
//
// 本项目主要遵循 MIT 许可证和 Apache 许可证（版本 2.0）进行分发和使用。许可证位于源代码树根目录中的 LICENSE-MIT 和 LICENSE-APACHE 文件。
//
// 不得利用本项目从事危害国家安全、扰乱社会秩序、侵犯他人合法权益等法律法规禁止的活动！任何基于本项目二次开发而产生的一切法律纠纷和责任，我们不承担任何责任！

namespace Admin.NET.Core;

/// <summary>
/// 系统错误码
/// </summary>
[ErrorCodeType]
[Description("系统错误码")]
public enum ErrorCodeEnum
{
    /// <summary>
    /// 验证码错误
    /// </summary>
    [ErrorCodeItemMetadata("验证码错误")]
    D0008,

    /// <summary>
    /// 账号不存在
    /// </summary>
    [ErrorCodeItemMetadata("账号不存在")]
    D0009,

    /// <summary>
    /// 密匙不匹配
    /// </summary>
    [ErrorCodeItemMetadata("密匙不匹配")]
    D0010,

    /// <summary>
    /// 密码不正确
    /// </summary>
    [ErrorCodeItemMetadata("密码不正确")]
    D1000,

    /// <summary>
    /// 非法操作！禁止删除自己
    /// </summary>
    [ErrorCodeItemMetadata("非法操作，禁止删除自己")]
    D1001,

    /// <summary>
    /// 记录不存在
    /// </summary>
    [ErrorCodeItemMetadata("记录不存在")]
    D1002,

    /// <summary>
    /// 账号已存在
    /// </summary>
    [ErrorCodeItemMetadata("账号已存在")]
    D1003,

    /// <summary>
    /// 旧密码不匹配
    /// </summary>
    [ErrorCodeItemMetadata("旧密码输入错误")]
    D1004,

    /// <summary>
    /// 测试数据禁止更改admin密码
    /// </summary>
    [ErrorCodeItemMetadata("测试数据禁止更改用户【admin】密码")]
    D1005,

    /// <summary>
    /// 数据已存在
    /// </summary>
    [ErrorCodeItemMetadata("数据已存在")]
    D1006,

    /// <summary>
    /// 数据不存在或含有关联引用，禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("数据不存在或含有关联引用，禁止删除")]
    D1007,

    /// <summary>
    /// 禁止为管理员分配角色
    /// </summary>
    [ErrorCodeItemMetadata("禁止为管理员分配角色")]
    D1008,

    /// <summary>
    /// 重复数据或记录含有不存在数据
    /// </summary>
    [ErrorCodeItemMetadata("重复数据或记录含有不存在数据")]
    D1009,

    /// <summary>
    /// 禁止为超级管理员角色分配权限
    /// </summary>
    [ErrorCodeItemMetadata("禁止为超级管理员角色分配权限")]
    D1010,

    /// <summary>
    /// 非法操作，未登录
    /// </summary>
    [ErrorCodeItemMetadata("非法操作，未登录")]
    D1011,

    /// <summary>
    /// Id不能为空
    /// </summary>
    [ErrorCodeItemMetadata("Id不能为空")]
    D1012,

    /// <summary>
    /// 所属机构不在自己的数据范围内
    /// </summary>
    [ErrorCodeItemMetadata("没有权限操作该数据")]
    D1013,

    /// <summary>
    /// 禁止删除超级管理员
    /// </summary>
    [ErrorCodeItemMetadata("禁止删除超级管理员")]
    D1014,

    /// <summary>
    /// 禁止修改超级管理员状态
    /// </summary>
    [ErrorCodeItemMetadata("禁止修改超级管理员状态")]
    D1015,

    /// <summary>
    /// 没有权限
    /// </summary>
    [ErrorCodeItemMetadata("没有权限")]
    D1016,

    /// <summary>
    /// 账号已冻结
    /// </summary>
    [ErrorCodeItemMetadata("账号已冻结")]
    D1017,

    /// <summary>
    /// 该租户下角色菜单权限集为空
    /// </summary>
    [ErrorCodeItemMetadata("该租户下角色菜单权限集为空")]
    D1019,

    /// <summary>
    /// 禁止删除默认租户
    /// </summary>
    [ErrorCodeItemMetadata("禁止删除默认租户")]
    D1023,

    /// <summary>
    /// 已将其他地方登录账号下线
    /// </summary>
    [ErrorCodeItemMetadata("已将其他地方登录账号下线")]
    D1024,

    /// <summary>
    /// 此角色下面存在账号禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("此角色下面存在账号禁止删除")]
    D1025,

    /// <summary>
    /// 禁止修改本人账号状态
    /// </summary>
    [ErrorCodeItemMetadata("禁止修改本人账号状态")]
    D1026,

    /// <summary>
    /// 密码错误次数过多，账号已锁定，请半小时后重试！
    /// </summary>
    [ErrorCodeItemMetadata("密码错误次数过多，账号已锁定，请半小时后重试！")]
    D1027,

    /// <summary>
    /// 新密码不能与旧密码相同
    /// </summary>
    [ErrorCodeItemMetadata("新密码不能与旧密码相同")]
    D1028,

    /// <summary>
    /// 系统默认账号禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("系统默认账号禁止删除")]
    D1029,

    /// <summary>
    /// 开放接口绑定账号禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("开放接口绑定账号禁止删除")]
    D1030,

    /// <summary>
    /// 开放接口绑定租户禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("开放接口绑定租户禁止删除")]
    D1031,

    /// <summary>
    /// 手机号已存在
    /// </summary>
    [ErrorCodeItemMetadata("手机号已存在")]
    D1032,

    /// <summary>
    /// 此角色下存在注册方案禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("此角色下存在注册方案禁止删除")]
    D1033,

    /// <summary>
    /// 注册功能未开启禁止注册
    /// </summary>
    [ErrorCodeItemMetadata("注册功能未开启禁止注册")]
    D1034,

    /// <summary>
    /// 注册方案不存在
    /// </summary>
    [ErrorCodeItemMetadata("注册方案不存在")]
    D1035,

    /// <summary>
    /// 角色不存在
    /// </summary>
    [ErrorCodeItemMetadata("角色不存在")]
    D1036,

    /// <summary>
    /// 禁止注册超级管理员和系统管理员
    /// </summary>
    [ErrorCodeItemMetadata("禁止注册超级管理员和系统管理员")]
    D1037,

    /// <summary>
    /// 禁止越权操作系统账户
    /// </summary>
    [ErrorCodeItemMetadata("禁止越权操作系统账户")]
    D1038,

    /// <summary>
    /// 父机构不存在
    /// </summary>
    [ErrorCodeItemMetadata("父机构不存在")]
    D2000,

    /// <summary>
    /// 当前机构Id不能与父机构Id相同
    /// </summary>
    [ErrorCodeItemMetadata("当前机构Id不能与父机构Id相同")]
    D2001,

    /// <summary>
    /// 已有相同组织机构,编码或名称相同
    /// </summary>
    [ErrorCodeItemMetadata("已有相同组织机构,编码或名称相同")]
    D2002,

    /// <summary>
    /// 没有权限操作机构
    /// </summary>
    [ErrorCodeItemMetadata("没有权限操作机构")]
    D2003,

    /// <summary>
    /// 该机构下有用户禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("该机构下有用户禁止删除")]
    D2004,

    /// <summary>
    /// 附属机构下有用户禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("附属机构下有用户禁止删除")]
    D2005,

    /// <summary>
    /// 只能增加下级机构
    /// </summary>
    [ErrorCodeItemMetadata("只能增加下级机构")]
    D2006,

    /// <summary>
    /// 下级机构下有用户禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("下级机构下有用户禁止删除")]
    D2007,

    /// <summary>
    /// 系统默认机构禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("系统默认机构禁止删除")]
    D2008,

    /// <summary>
    /// 禁止增加根节点机构
    /// </summary>
    [ErrorCodeItemMetadata("禁止增加根节点机构")]
    D2009,

    /// <summary>
    /// 此机构下存在注册方案禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("此机构下存在注册方案禁止删除")]
    D2010,

    /// <summary>
    /// 机构不存在
    /// </summary>
    [ErrorCodeItemMetadata("机构不存在")]
    D2011,

    /// <summary>
    /// 系统默认机构禁止修改
    /// </summary>
    [ErrorCodeItemMetadata("系统默认机构禁止修改")]
    D2012,

    /// <summary>
    /// 字典类型不存在
    /// </summary>
    [ErrorCodeItemMetadata("字典类型不存在")]
    D3000,

    /// <summary>
    /// 字典类型已存在
    /// </summary>
    [ErrorCodeItemMetadata("字典类型已存在,名称或编码重复")]
    D3001,

    /// <summary>
    /// 字典类型下面有字典值禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("字典类型下面有字典值禁止删除")]
    D3002,

    /// <summary>
    /// 字典值已存在
    /// </summary>
    [ErrorCodeItemMetadata("字典值已存在")]
    D3003,

    /// <summary>
    /// 字典值不存在
    /// </summary>
    [ErrorCodeItemMetadata("字典值不存在")]
    D3004,

    /// <summary>
    /// 字典状态错误
    /// </summary>
    [ErrorCodeItemMetadata("字典状态错误")]
    D3005,

    /// <summary>
    /// 字典编码不能以Enum结尾
    /// </summary>
    [ErrorCodeItemMetadata("字典编码不能以Enum结尾")]
    D3006,

    /// <summary>
    /// 禁止修改枚举类型的字典编码
    /// </summary>
    [ErrorCodeItemMetadata("禁止修改枚举类型的字典编码")]
    D3007,

    /// <summary>
    /// 禁止迁移枚举字典
    /// </summary>
    [ErrorCodeItemMetadata("禁止迁移枚举字典")]
    D3008,

    /// <summary>
    /// 字典已在该租户禁止迁移
    /// </summary>
    [ErrorCodeItemMetadata("字典已在该租户禁止迁移")]
    D3009,

    /// <summary>
    /// 非超管用户禁止操作系统字典
    /// </summary>
    [ErrorCodeItemMetadata("非超管用户禁止操作系统字典")]
    D3010,

    /// <summary>
    /// 获取字典值集合入参有误
    /// </summary>
    [ErrorCodeItemMetadata("获取字典值集合入参有误")]
    D3011,

    /// <summary>
    /// 禁止修改租户字典状态
    /// </summary>
    [ErrorCodeItemMetadata("禁止修改租户字典状态")]
    D3012,

    /// <summary>
    /// 菜单已存在
    /// </summary>
    [ErrorCodeItemMetadata("菜单已存在")]
    D4000,

    /// <summary>
    /// 路由地址为空
    /// </summary>
    [ErrorCodeItemMetadata("路由地址为空")]
    D4001,

    /// <summary>
    /// 打开方式为空
    /// </summary>
    [ErrorCodeItemMetadata("打开方式为空")]
    D4002,

    /// <summary>
    /// 权限标识格式为空
    /// </summary>
    [ErrorCodeItemMetadata("权限标识格式为空")]
    D4003,

    /// <summary>
    /// 权限标识格式错误
    /// </summary>
    [ErrorCodeItemMetadata("权限标识格式错误 如xxx:xxx")]
    D4004,

    /// <summary>
    /// 权限不存在
    /// </summary>
    [ErrorCodeItemMetadata("权限不存在")]
    D4005,

    /// <summary>
    /// 父级菜单不能为当前节点，请重新选择父级菜单
    /// </summary>
    [ErrorCodeItemMetadata("父级菜单不能为当前节点，请重新选择父级菜单")]
    D4006,

    /// <summary>
    /// 不能移动根节点
    /// </summary>
    [ErrorCodeItemMetadata("不能移动根节点")]
    D4007,

    /// <summary>
    /// 禁止本节点与父节点相同
    /// </summary>
    [ErrorCodeItemMetadata("禁止本节点与父节点相同")]
    D4008,

    /// <summary>
    /// 路由名称重复
    /// </summary>
    [ErrorCodeItemMetadata("路由名称重复")]
    D4009,

    /// <summary>
    /// 父节点不能为按钮类型
    /// </summary>
    [ErrorCodeItemMetadata("父节点不能为按钮类型")]
    D4010,

    /// <summary>
    /// 租户不能为空
    /// </summary>
    [ErrorCodeItemMetadata("租户不能为空")]
    D4011,

    /// <summary>
    /// 系统菜单禁止修改
    /// </summary>
    [ErrorCodeItemMetadata("系统菜单禁止修改")]
    D4012,

    /// <summary>
    /// 系统菜单禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("系统菜单禁止删除")]
    D4013,

    /// <summary>
    /// 已存在同名或同编码应用
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名或同编码应用")]
    D5000,

    /// <summary>
    /// 默认激活系统只能有一个
    /// </summary>
    [ErrorCodeItemMetadata("默认激活系统只能有一个")]
    D5001,

    /// <summary>
    /// 该应用下有菜单禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("该应用下有菜单禁止删除")]
    D5002,

    /// <summary>
    /// 已存在同名或同编码应用
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名或同编码应用")]
    D5003,

    /// <summary>
    /// 已存在同名或同编码职位
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名或同编码职位")]
    D6000,

    /// <summary>
    /// 该职位下有用户禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("该职位下有用户禁止删除")]
    D6001,

    /// <summary>
    /// 无权修改本职位
    /// </summary>
    [ErrorCodeItemMetadata("无权修改本职位")]
    D6002,

    /// <summary>
    /// 职位不存在
    /// </summary>
    [ErrorCodeItemMetadata("职位不存在")]
    D6003,

    /// <summary>
    /// 此职位下存在注册方案禁止删除
    /// </summary>
    [ErrorCodeItemMetadata("此职位下存在注册方案禁止删除")]
    D6004,

    /// <summary>
    /// 通知公告状态错误
    /// </summary>
    [ErrorCodeItemMetadata("通知公告状态错误")]
    D7000,

    /// <summary>
    /// 通知公告删除失败
    /// </summary>
    [ErrorCodeItemMetadata("通知公告删除失败")]
    D7001,

    /// <summary>
    /// 通知公告编辑失败
    /// </summary>
    [ErrorCodeItemMetadata("通知公告编辑失败，类型必须为草稿")]
    D7002,

    /// <summary>
    /// 通知公告操作失败，非发布者不能进行操作
    /// </summary>
    [ErrorCodeItemMetadata("通知公告操作失败，非发布者不能进行操作")]
    D7003,

    /// <summary>
    /// 文件不存在
    /// </summary>
    [ErrorCodeItemMetadata("文件不存在")]
    D8000,

    /// <summary>
    /// 不允许的文件类型
    /// </summary>
    [ErrorCodeItemMetadata("不允许的文件类型")]
    D8001,

    /// <summary>
    /// 文件超过允许大小
    /// </summary>
    [ErrorCodeItemMetadata("文件超过允许大小")]
    D8002,

    /// <summary>
    /// 文件后缀错误
    /// </summary>
    [ErrorCodeItemMetadata("文件后缀错误")]
    D8003,

    /// <summary>
    /// 文件已存在
    /// </summary>
    [ErrorCodeItemMetadata("文件已存在")]
    D8004,

    /// <summary>
    /// 无效的文件名
    /// </summary>
    [ErrorCodeItemMetadata("无效的文件名")]
    D8005,

    /// <summary>
    /// 已存在同名或同编码参数配置
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名或同编码参数配置")]
    D9000,

    /// <summary>
    /// 禁止删除系统参数
    /// </summary>
    [ErrorCodeItemMetadata("禁止删除系统参数")]
    D9001,

    /// <summary>
    /// 已存在同名任务调度
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名任务调度")]
    D1100,

    /// <summary>
    /// 任务调度不存在
    /// </summary>
    [ErrorCodeItemMetadata("任务调度不存在")]
    D1101,

    /// <summary>
    /// 演示环境禁止修改数据
    /// </summary>
    [ErrorCodeItemMetadata("演示环境禁止修改数据")]
    D1200,

    /// <summary>
    /// 已存在同名的租户
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名的租户")]
    D1300,

    /// <summary>
    /// 已存在同名的租户管理员
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名的租户管理员")]
    D1301,

    /// <summary>
    /// 租户从库配置错误
    /// </summary>
    [ErrorCodeItemMetadata("租户从库配置错误")]
    D1302,

    /// <summary>
    /// 已存在同名的租户域名
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名的租户域名")]
    D1303,

    /// <summary>
    /// 授权菜单存在重复项
    /// </summary>
    [ErrorCodeItemMetadata("授权菜单存在重复项")]
    D1304,

    /// <summary>
    /// 该表代码模板已经生成过
    /// </summary>
    [ErrorCodeItemMetadata("该表代码模板已经生成过")]
    D1400,

    /// <summary>
    /// 数据库配置不存在
    /// </summary>
    [ErrorCodeItemMetadata("数据库配置不存在")]
    D1401,

    /// <summary>
    /// 该类型不存在
    /// </summary>
    [ErrorCodeItemMetadata("该类型不存在")]
    D1501,

    /// <summary>
    /// 该字段不存在
    /// </summary>
    [ErrorCodeItemMetadata("该字段不存在")]
    D1502,

    /// <summary>
    /// 该类型不是枚举类型
    /// </summary>
    [ErrorCodeItemMetadata("该类型不是枚举类型")]
    D1503,

    /// <summary>
    /// 该实体不存在
    /// </summary>
    [ErrorCodeItemMetadata("该实体不存在")]
    D1504,

    /// <summary>
    /// 父菜单不存在
    /// </summary>
    [ErrorCodeItemMetadata("父菜单不存在")]
    D1505,

    /// <summary>
    /// 父资源不存在
    /// </summary>
    [ErrorCodeItemMetadata("父资源不存在")]
    D1600,

    /// <summary>
    /// 当前资源Id不能与父资源Id相同
    /// </summary>
    [ErrorCodeItemMetadata("当前资源Id不能与父资源Id相同")]
    D1601,

    /// <summary>
    /// 已有相同编码或名称
    /// </summary>
    [ErrorCodeItemMetadata("已有相同编码或名称")]
    D1602,

    /// <summary>
    /// 脚本代码不能为空
    /// </summary>
    [ErrorCodeItemMetadata("脚本代码不能为空")]
    D1701,

    /// <summary>
    /// 脚本代码中的作业类，需要定义 [JobDetail] 特性
    /// </summary>
    [ErrorCodeItemMetadata("脚本代码中的作业类，需要定义 [JobDetail] 特性")]
    D1702,

    /// <summary>
    /// 作业编号需要与脚本代码中的作业类 [JobDetail('jobId')] 一致
    /// </summary>
    [ErrorCodeItemMetadata("作业编号需要与脚本代码中的作业类 [JobDetail('jobId')] 一致")]
    D1703,

    /// <summary>
    /// 禁止修改作业编号
    /// </summary>
    [ErrorCodeItemMetadata("禁止修改作业编号")]
    D1704,

    /// <summary>
    /// 执行作业失败
    /// </summary>
    [ErrorCodeItemMetadata("执行作业失败")]
    D1705,

    /// <summary>
    /// 已存在同名打印模板
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名打印模板")]
    D1800,

    /// <summary>
    /// 已存在同名功能或同名程序及插件
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名功能或同名程序及插件")]
    D1900,

    /// <summary>
    /// 注册方案名称已存在
    /// </summary>
    [ErrorCodeItemMetadata("注册方案名称已存在")]
    D2101,

    /// <summary>
    /// 已存在同名模板
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名模板")]
    T1000,

    /// <summary>
    /// 已存在相同编码模板
    /// </summary>
    [ErrorCodeItemMetadata("已存在相同编码模板")]
    T1001,

    /// <summary>
    /// 禁止删除存在关联租户的应用
    /// </summary>
    [ErrorCodeItemMetadata("禁止删除存在关联租户的应用")]
    A1001,

    /// <summary>
    /// 禁止删除存在关联菜单的应用
    /// </summary>
    [ErrorCodeItemMetadata("禁止删除存在关联菜单的应用")]
    A1002,

    /// <summary>
    /// 找不到系统应用
    /// </summary>
    [ErrorCodeItemMetadata("找不到系统应用")]
    A1000,

    /// <summary>
    /// 已存在同名或同编码项目
    /// </summary>
    [ErrorCodeItemMetadata("已存在同名或同编码项目")]
    xg1000,

    /// <summary>
    /// 已存在相同证件号码人员
    /// </summary>
    [ErrorCodeItemMetadata("已存在相同证件号码人员")]
    xg1001,

    /// <summary>
    /// 检测数据不存在
    /// </summary>
    [ErrorCodeItemMetadata("检测数据不存在")]
    xg1002,

    /// <summary>
    /// 请添加数据列
    /// </summary>
    [ErrorCodeItemMetadata("请添加数据列")]
    db1000,

    /// <summary>
    /// 数据表不存在
    /// </summary>
    [ErrorCodeItemMetadata("数据表不存在")]
    db1001,

    /// <summary>
    /// 数据表不存在
    /// </summary>
    [ErrorCodeItemMetadata("不允许添加相同字段名")]
    db1002,

    /// <summary>
    /// 实体文件不存在或匹配不到。如果是刚刚生成的实体，请重启服务后再试
    /// </summary>
    [ErrorCodeItemMetadata("实体文件不存在或匹配不到。如果是刚刚生成的实体，请重启服务后再试")]
    db1003,

    /// <summary>
    /// 父节点不存在
    /// </summary>
    [ErrorCodeItemMetadata("父节点不存在")]
    R2000,

    /// <summary>
    /// 当前节点Id不能与父节点Id相同
    /// </summary>
    [ErrorCodeItemMetadata("当前节点Id不能与父节点Id相同")]
    R2001,

    /// <summary>
    /// 已有相同编码或名称
    /// </summary>
    [ErrorCodeItemMetadata("已有相同编码或名称")]
    R2002,

    /// <summary>
    /// 行政区代码只能为6、9或12位
    /// </summary>
    [ErrorCodeItemMetadata("行政区代码只能为6、9或12位")]
    R2003,

    /// <summary>
    /// 父节点不能为自己的子节点
    /// </summary>
    [ErrorCodeItemMetadata("父节点不能为自己的子节点")]
    R2004,

    /// <summary>
    /// 同步国家统计局数据异常,请稍后重试
    /// </summary>
    [ErrorCodeItemMetadata("同步国家统计局数据异常,请稍后重试")]
    R2005,

    /// <summary>
    /// 默认租户状态禁止修改
    /// </summary>
    [ErrorCodeItemMetadata("默认租户状态禁止修改")]
    Z1001,

    /// <summary>
    /// 禁止创建此类型的数据库
    /// </summary>
    [ErrorCodeItemMetadata("禁止创建此类型的数据库")]
    Z1002,

    /// <summary>
    /// 租户不存在或已禁用
    /// </summary>
    [ErrorCodeItemMetadata("租户不存在或已禁用")]
    Z1003,

    /// <summary>
    /// 租户库连接不能为空
    /// </summary>
    [ErrorCodeItemMetadata("租户库连接不能为空")]
    Z1004,

    /// <summary>
    /// 身份标识已存在
    /// </summary>
    [ErrorCodeItemMetadata("身份标识已存在")]
    O1000,

    /// <summary>
    /// 禁止非超级管理员操作
    /// </summary>
    [ErrorCodeItemMetadata("禁止非超级管理员操作")]
    SA001
}