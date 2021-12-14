//1 解决资源访问冲突
//2 有些数据只应保存一份 全局唯一处理（配置信息 用户信息中心 唯一ID生成器）
//3 节省内存

//1 构造private 2 对象创建安全问题 3 是否支持延迟加载 4 get操作性能(加锁)

using System;
namespace Design
{


    //饿汉式 不支持延迟加载
     public class Singleton
    {
        private static Singleton instance = new Singleton();
        public static Singleton I
        {
            get
            {
                return instance;
            }
        }

        private Singleton()
        {
            
        }

        public void Print()
        {
            
        }
    }
}
