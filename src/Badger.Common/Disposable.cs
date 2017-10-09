using System;

namespace Badger.Common
{
    public sealed class Disposable : IDisposable
    {
        private Action dispose;

        internal Disposable(Action dispose)
        {
            this.dispose = dispose;
        }

        public static IDisposable From(Action dispose) 
        {
            return new Disposable(dispose);
        }

        void IDisposable.Dispose()
        {
            dispose?.Invoke();
            dispose = null;
        }
    }
}