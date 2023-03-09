using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YahooFinance.Domain.Interfaces.Repository;

namespace Infra.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<YahooFinanceDbContext> _db;
        public RepositoryBase()
        {
            _db = new DbContextOptions<YahooFinanceDbContext>();
            
        }
        public async Task Add(T obj)
        {
            using (var data = new YahooFinanceDbContext(_db))
            {
                await data.Set<T>().AddAsync(obj);
                await data.SaveChangesAsync();
            }
        }

        public async Task Delete(T obj)
        {
            using (var data = new YahooFinanceDbContext(_db))
            {
                data.Set<T>().Remove(obj);
                await data.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var data = new YahooFinanceDbContext(_db))
            {
                return await data.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var data = new YahooFinanceDbContext(_db))
            {
                return await data.Set<T>().FindAsync(id);
            }
        }

        public async Task Update(T obj)
        {
            using (var data = new YahooFinanceDbContext(_db))
            {
                data.Set<T>().Update(obj);
                await data.SaveChangesAsync();
            }
        }

        #region Dispose

        // To detect redundant calls
        private bool _disposedValue;

        // Instantiate a SafeHandle instance.
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose() => Dispose(true);

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _safeHandle.Dispose();
                }

                _disposedValue = true;
            }
        }

        #endregion
    }
}
