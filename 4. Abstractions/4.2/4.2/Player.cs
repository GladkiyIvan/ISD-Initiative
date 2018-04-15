using System;

namespace _4._2
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Статус: воспроизведение");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Статус: воспр. приостановлено");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Статус: воспр. прекращенo");
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Статус: запись");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Статус: запись приостановлена");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Статус: запись прекращена");
        }
    }
}
