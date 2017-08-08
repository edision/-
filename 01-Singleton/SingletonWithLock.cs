// ������       �⽣��
// ����ʱ�� 2017-08-06 20:58

#region using

using System;

#endregion

namespace Singleton
{
    /// <summary>
    /// ����ģʽ
    /// <remarks>
    /// <para>
    /// ͨ���߳�����֧�ֲ����̻߳�ȡʵ����Ϊ��������ܣ�ʹ����˫���жϡ�
    /// </para>
    /// </remarks>
    /// </summary>
    internal class SingletonWithLock
    {
        private static SingletonWithLock instance = null;
        private static readonly object padLock = new object();

        private SingletonWithLock()
        {
            Console.WriteLine("SingletonWithLock created!");
        }

        public static SingletonWithLock Instance
        {
            get
            {
                if (instance == null) // �������жϣ�����ÿ�ζ�lock,������ܡ�
                {
                    lock (padLock)
                    {
                        if (instance == null) // �߳��ڲ��߼�
                        {
                            instance = new SingletonWithLock();
                        }
                    }
                }
                return instance;
            }
        }
    }
}