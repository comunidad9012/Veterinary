using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass.Common
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        ///<summary>
        /// 	Metodo usado para insertar un registro en la base de datos.
        ///</summary>
        ///<param name = 'entity'> Entidad que posee los datos a insertar.</param>
        ///<returns>uwu</returns>
        Task Insert(TEntity entity);
        ///<summary>
        /// 	Metodo usado para actualizar un registro en la base de datos.
        ///</summary>
        ///<param name = 'entity'> Entidad que posee los datos a insertar.</param>
        ///<returns></returns>
        Task<int> Update(TEntity entity);
        ///<summary>
        /// 	Metodo usado para borrar un registro en la base de datos.
        ///</summary>
        ///<param name = 'entity'> Entidad que posee los datos a insertar.</param>
        ///<returns></returns>
        Task Delete(TEntity entity);
        ///<summary>
        /// 	
        ///</summary>
        ///<param name = 'entity'> Entidad que posee los datos a insertar.</param>
        ///<returns></returns>
        Task<IEnumerable<TEntity>> GetAll();
        ///<summary>
        /// 	Metodo usado para insertar un registro en la base de datos.
        ///</summary>
        ///<param name = 'entity'> Entidad que posee los datos a insertar.</param>
        ///<returns></returns>
        Task<int> SaveChange();

    }
}
