using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S.O.L.I.D.AsyncProgramming
{
    class MyAsync
    {
        public static async void M1()
        {
            Task taskResult = null;
            CancellationTokenSource cts = new CancellationTokenSource();
            try
            {
                cts.Cancel();
                Task a1 = M2("awaitable method1", cts.Token);
                Task a2 = M3("awaitable method2");
                
                if (!taskResult.IsFaulted)
                    await (taskResult = Task.WhenAll(a1, a2));
                Console.WriteLine("after");
            }
            catch (Exception ex)
            {
                
                foreach (var item in taskResult.Exception.InnerExceptions)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static Task M2(string str, CancellationToken ct)
        {
            try
            {
                return Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    throw new NullReferenceException();
                    Console.WriteLine(str);
                });
            }
            catch(Exception)
            {
                ct.ThrowIfCancellationRequested();
                return null;
            }
        }

        public static Task M3(string str)
        {
            return Task.Run(() => {
                Console.WriteLine(str);
            });
        }

        public static void DataParrellism()
        {
            Parallel.For(1, 3, async(int i) => {
                await Task.Run(() => Console.WriteLine(i));
            });
        }

        public static void TaskParellism()
        {
            Parallel.Invoke(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("1st method");
            },
            () =>
            {
                Console.WriteLine("2nd method");
            });
        }
    }
}
