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
        public static Singleton I { get { return instance; } }
        private Singleton(){   }
    }

    //懒汉式
    public class Singleton2
    {
        private Singleton2() { }
        private static Singleton2 instance;
        public static Singleton2 I
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
                return instance;
            }
        }
    }

    public class Singleton3
    {
        private Singleton3() { }
        private static Object lockObj = new object();
        private static Singleton3 instance;
        public static Singleton3 I
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public class Singleton4<T> where T : new()
    {
        protected Singleton4()  { }
        private static T instance;
        public static T I
        {
            get
            {
                if (instance == null)
                {

                    if (instance == null)
                    {
                        instance = new T();
                    }
                }
                return instance;
            }
        }
    }
}
