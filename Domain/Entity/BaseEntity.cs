using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Entity
{
    /// <summary>
    ///    Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущностей
        /// </summary>
        protected Guid Id { get; set; }

        protected DateTime CreationDate { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not BaseEntity entity)
                return false;
            if (ReferenceEquals(this, entity)) return true;
            if (Id != entity.Id)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
 
    }
}