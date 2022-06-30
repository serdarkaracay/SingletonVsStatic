using System;
using Xunit;

namespace SingletonVsStatic.Sigleton.Tests
{
    public class MySingletonCache_Tests
    {
        private readonly MySingletonCache _mySingletonCache;

        public MySingletonCache_Tests()
        {
            _mySingletonCache = new MySingletonCache();
        }

        [Fact]
        public void Add_Should_Throw_Exception_For_Nulls()
        {
            var sc = _mySingletonCache.GetOrThrowException("");
            Assert.Throws<ArgumentNullException>(() =>
            {
                _mySingletonCache.Add("MyNumber", null);
            });
        }

        [Fact]
        public void Add_Should_Not_Throw_Exception_For_Nulls()
        {
            _mySingletonCache.Add("MyNumber", 42);
        }
    }
}
