using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Com.App.Model
{
    public interface IEntity : IEntity<int>
    {
        // int Id { get; set; }
    }
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }

    //public class Entity : IEntity<TPrimaryKey>
    //{
    // public TPrimaryKey Id { get; set; }
    //}
    public abstract class Entity : Entity<int>, IEntity
    {

    }
    public abstract class TreeEntity : Entity
    {
        /// <summary>
        /// 父节点名称
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 父节点名称
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 节点语义ID
        /// </summary>
        public string CascadeId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }
    /// <summary>
    /// Basic implementation of IEntity interface.
    /// An entity can inherit this class of directly implement to IEntity interface.
    /// </summary>
    /// <typeparam name="TPrimaryKey">Type of the primary key of the entity</typeparam>
    [Serializable]
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        public virtual TPrimaryKey Id { get; set; }

        /// <summary>
        /// Checks if this entity is transient (it has not an Id).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>

    }
}


